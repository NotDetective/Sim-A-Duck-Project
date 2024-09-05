﻿using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class MallardDuck() : Duck(new FlyWithWings(), new RegularQuack(), new SwimOnWater())
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
