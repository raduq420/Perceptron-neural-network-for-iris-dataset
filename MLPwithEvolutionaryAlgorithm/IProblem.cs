using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLPwithEvolutionaryAlgorithm
{
    public interface IOptimizationProblem
    {
        void ComputeFitness(Chromosome c);
        Chromosome MakeChromosome();
    }
}
