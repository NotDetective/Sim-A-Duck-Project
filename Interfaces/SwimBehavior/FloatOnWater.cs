namespace StrategyPattern.Interfaces.SwimBehavior;

public class FloatOnWater : SwimBehavior
{
    public void Swim()
    {
        Console.WriteLine("I'm floating on water");
    }
}