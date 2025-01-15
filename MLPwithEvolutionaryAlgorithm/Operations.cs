using System;
using System.IO;

namespace MLPwithEvolutionaryAlgorithm
{
    /// <summary>
    /// Clasa pentru operatia de selectie
    /// </summary>
    public static class Selection
    {
        private static Random _random = new Random();

        public static Chromosome Tournament(Chromosome[] population)
        {
            int idx1 = _random.Next(population.Length);
            int idx2;
            do
            {
                idx2 = _random.Next(population.Length);
            } while (idx1 == idx2);

            return population[idx1].Fitness > population[idx2].Fitness ? population[idx1] : population[idx2];
        }

        public static Chromosome GetBest(Chromosome[] population)
        {
            Chromosome bestChromosome = population[0];
            foreach (var chrom in population)
            {
                if (chrom.Fitness > bestChromosome.Fitness)
                {
                    bestChromosome = chrom;
                }
            }
            return new Chromosome(bestChromosome);
        }
    }

    //==================================================================================

    /// <summary>
    /// Clasa pentru operatia de incrucisare
    /// </summary>
    public static class Crossover
    {
        private static Random _random = new Random();

        public static Chromosome Arithmetic(Chromosome mother, Chromosome father, double rate)
        {
            if (_random.NextDouble() < rate)
            {
                double coefficient = _random.NextDouble();
                double[] offspringGenes = new double[father.NoGenes];
                for (int i = 0; i < father.NoGenes; i++)
                {
                    //ne folosim de incrucisarea reala

                    offspringGenes[i] = coefficient * mother.Genes[i] + (1 - coefficient) * father.Genes[i];

                }
                Chromosome offspring = new Chromosome(father)
                {
                    Genes = offspringGenes
                };
                return offspring;
            }

            return _random.Next(2) == 0 ? father : mother;
        }
    }

    //==================================================================================

    /// <summary>
    /// Clasa pentru operatia de mutatie
    /// </summary>
    public static class Mutation
    {
        private static Random _random = new Random();

        public static void ApplyMutation(Chromosome child, double mutationRate)
        {
            //folosim mutatia reala
            for (int i = 0; i < child.NoGenes; i++)
            {
                if (_random.NextDouble() < mutationRate)
                {
                    child.Genes[i] = child.MinValues[i] + _random.NextDouble() * (child.MaxValues[i] - child.MinValues[i]);
                }
            }
        }
    }

    //==================================================================================

    /// <summary>
    /// Clasa pentru implementarea algoritmului evolutiv
    /// </summary>
    public class EvolutionaryAlgorithm
    {
        private string[] _dataLines;

        public Chromosome Solve(IOptimizationProblem problem, int populationSize, int maxGenerations, double crossoverRate, double mutationRate)
        {
            try
            {
                _dataLines = File.ReadAllLines("iris.data");

                Chromosome[] population = new Chromosome[populationSize];
                InitializePopulation(population, problem);

                for (int generation = 0; generation < maxGenerations; generation++)
                {
                    Chromosome[] newPopulation = new Chromosome[populationSize];
                    newPopulation[0] = Selection.GetBest(population); // Elitism

                    for (int i = 1; i < populationSize; i++)
                    {
                        //luam 2 parinti prin tournament
                        Chromosome parent1 = Selection.Tournament(population);
                        Chromosome parent2 = Selection.Tournament(population);

                        //generam copil folosindu-ne de crossover
                        Chromosome child = Crossover.Arithmetic(parent1, parent2, crossoverRate);

                        //aplicam si mutatia pe copil
                        Mutation.ApplyMutation(child, mutationRate);

                        //facem fitness pentru copil
                        problem.ComputeFitness(child);

                        //adaugam copilul in populatia noua
                        newPopulation[i] = child;
                    }

                    population = newPopulation;
                }

                return Selection.GetBest(population);
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception("Data file not found.", ex);
            }
        }

        private void InitializePopulation(Chromosome[] population, IOptimizationProblem problem)
        {
            for (int i = 0; i < population.Length; i++)
            {
                population[i] = problem.MakeChromosome();
                var dataParts = _dataLines[i].Split(',');

                if (dataParts.Length != 5)
                    continue;

                for (int j = 0; j < 4; j++)
                {
                    population[i].Genes[j] = double.Parse(dataParts[j]);
                }

                population[i].Genes[4] = dataParts[4] == "Iris-setosa" ? 0.9 :
                         (dataParts[4] == "Iris-versicolor" ? 0.95 : 0.99);

                problem.ComputeFitness(population[i]);
            }
        }
    }
}
