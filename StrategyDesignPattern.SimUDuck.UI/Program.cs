using StrategyDesignPattern.SimUDuck.Operations.Actions;
using System;

namespace StrategyDesignPattern.SimUDuck.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuckAction duck = new MallardDuckAction();
            duck.Execute();

            Console.WriteLine("*******************************************");

            ModelDuckAction model = new ModelDuckAction();
            model.Execute();
        }
    }
}
