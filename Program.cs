using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static readonly Context context = new Context();
        static void Main(string[] args)
        {
            for(var index = 0; index < 5; index++)
            {
                context.DoSomething();
            }

            Console.ReadLine();
        }
    }
}
