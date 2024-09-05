using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern.Ducks;

internal class RobotDuck() : Duck(new FlyNoWay(), new RegularQuack(), new SinkToBottom())
{
    public override void Display()
    {
        Console.WriteLine("I'm a Robot Duck");
    }
}