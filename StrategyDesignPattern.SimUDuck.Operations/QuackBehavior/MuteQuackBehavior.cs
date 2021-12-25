using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyDesignPattern.SimUDuck.Operations.Framework;

namespace StrategyDesignPattern.SimUDuck.Operations.QuackBehavior
{
    public class MuteQuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("MUTE!!!");
        }
    }
}
