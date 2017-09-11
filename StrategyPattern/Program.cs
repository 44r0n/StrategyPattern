using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new AlgorithmA());
            context.Solve(2);
            context = new Context(new AlgorithmB());
            context.Solve(3);
        }
    }
}