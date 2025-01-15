using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPwithEvolutionaryAlgorithm
{
    public class Iris : IOptimizationProblem
    {
        public void ComputeFitness(Chromosome c)
        {
            double score=0;
            for(int i=0;i<4;i++)
                score += c.Genes[i];
            c.Fitness = score * c.Genes[4]/10 -30;
        }

        public Chromosome MakeChromosome()
        {
            return new Chromosome(5,new double[] {0,0,0,0,0 }, new double[] { 10, 10, 10, 10,10 });
        }
    }
}
