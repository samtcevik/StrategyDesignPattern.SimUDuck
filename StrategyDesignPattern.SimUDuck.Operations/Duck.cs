using System;
using System.Collections.Generic;
using System.Text;
using StrategyDesignPattern.SimUDuck.Operations.Framework;

namespace StrategyDesignPattern.SimUDuck.Operations
{
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior { set; get; }
        public IFlyBehavior FlyBehavior { set; get; }
        protected Duck()
        {

        }

        public abstract void Execute();

    }
}
