using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.SimUDuck.Operations.Framework;

namespace StrategyDesignPattern.SimUDuck.Operations.FlyBehavior
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("FlyNoWay");
        }
    }
}
