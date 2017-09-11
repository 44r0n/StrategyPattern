using System;
namespace StrategyPattern
{
    public abstract class Strategy
    {
        public abstract void SolveSometing(int data);
        protected Strategy() { }
    }
}
