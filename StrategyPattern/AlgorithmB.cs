using System;
namespace StrategyPattern
{
    public class AlgorithmB : Strategy
    {
        public AlgorithmB()
        {
        }

        public override void SolveSometing(int data)
        {
            Console.WriteLine("Solved with algorithm B");
        }
    }
}
