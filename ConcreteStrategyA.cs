using System;

namespace StrategyPattern
{
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyA.Execte()");
        }
    }
}
