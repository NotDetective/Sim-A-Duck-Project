﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck() : Duck(new FlyNoWay(), new Squeak() , new FloatOnWater())
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
