using System;
namespace StrategyPattern
{
    public class AlgorithmA : Strategy
    {
        public AlgorithmA()
        {
        }

        public override void SolveSometing(int data)
        {
            Console.WriteLine("Solved with algorithm A");
        }
    }
}
