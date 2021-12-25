using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.SimUDuck.Operations.FlyBehavior;
using StrategyDesignPattern.SimUDuck.Operations.QuackBehavior;

namespace StrategyDesignPattern.SimUDuck.Operations.Actions
{
    public class MallardDuckAction : Duck
    {
        public MallardDuckAction()
        {
            QuackBehavior = new SqueakBehavior();
            FlyBehavior = new FlyRocketPower();
        }
        public override void Execute()
        {
            if (QuackBehavior != null && FlyBehavior != null)
            {
                Console.WriteLine(QuackBehavior.GetType().Name + " - " + FlyBehavior.GetType().Name);
            }
        }
    }
}
