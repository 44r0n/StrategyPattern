using System;
namespace StrategyPattern
{
    public class Context
    {
        private Strategy strategy;
        
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void Solve(int data)
        {
            strategy.SolveSometing(data);
        }
    }
}
