using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck(FlyBehavior flyBehavior, QuackBehavior quackBehavior, SwimBehavior swimBehavior)
    {
        //flyBehavior and quackBehavior are interfaces that are used to delegate the behavior of the duck
        protected FlyBehavior FlyBehavior { set; get; } = flyBehavior;

        protected QuackBehavior QuackBehavior { set; get; } = quackBehavior;

        protected SwimBehavior SwimBehavior { set; get; } = swimBehavior;

        public abstract void Display();

        public void PerformQuack()
        {
            this.QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            this.FlyBehavior.Fly();
        }
        public void PreformSwim()
        {
            this.SwimBehavior.Swim();
        }
    }
}
