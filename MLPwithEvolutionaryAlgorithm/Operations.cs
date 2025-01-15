using System;
using System.IO;

namespace MLPwithEvolutionaryAlgorithm
{
    /// <summary>
    /// Clasa pentru operatia de selectie
    /// </summary>
    public static class Selection
    {
      
    }

    //==================================================================================

    /// <summary>
    /// Clasa pentru operatia de incrucisare
    /// </summary>
    public static class Crossover
    {

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
