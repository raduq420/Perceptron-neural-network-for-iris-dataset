using System;

namespace MLPwithEvolutionaryAlgorithm
{
    public class Chromosome
    {
        public int NoGenes { get; set; } // Numarul de gene ale individului

        public double[] Genes { get; set; } // Valorile genelor

        public double[] MinValues { get; set; } // Limitele minime ale genelor

        public double[] MaxValues { get; set; } // Limitele maxime ale genelor

        public double Fitness { get; set; } // Valoarea functiei de adaptare a individului

        private static Random _rand = new Random();

        public Chromosome(int noGenes, double[] minValues, double[] maxValues)
        {
            NoGenes = noGenes;
            Genes = new double[noGenes];
            MinValues = new double[noGenes];
            MaxValues = new double[noGenes];

            // Initializare aleatorie a genelor
            for (int i = 0; i < noGenes; i++)
            {
                MinValues[i] = minValues[i];
                MaxValues[i] = maxValues[i];

                Genes[i] = minValues[i] + _rand.NextDouble() * (maxValues[i] - minValues[i]);
            }
        }

        public Chromosome(Chromosome c) // Constructor de copiere
        {
            NoGenes = c.NoGenes;
            Fitness = c.Fitness;

            Genes = new double[c.NoGenes];
            MinValues = new double[c.NoGenes];
            MaxValues = new double[c.NoGenes];

            for (int i = 0; i < c.Genes.Length; i++)
            {
                Genes[i] = c.Genes[i];
                MinValues[i] = c.MinValues[i];
                MaxValues[i] = c.MaxValues[i];
            }
        }
    }
}
