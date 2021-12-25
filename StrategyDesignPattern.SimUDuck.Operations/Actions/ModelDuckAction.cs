using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.SimUDuck.Operations.FlyBehavior;
using StrategyDesignPattern.SimUDuck.Operations.QuackBehavior;

namespace StrategyDesignPattern.SimUDuck.Operations.Actions
{
    public class ModelDuckAction : Duck
    {
        public ModelDuckAction()
        {
            QuackBehavior = new MuteQuackBehavior();
            FlyBehavior = new FlyNoWay();
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
