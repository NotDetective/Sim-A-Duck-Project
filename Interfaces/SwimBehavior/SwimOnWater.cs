namespace StrategyPattern.Interfaces.SwimBehavior;

public class SwimOnWater : SwimBehavior
{
    public void Swim()
    {
        Console.WriteLine("I'm swimming on the water");
    }
}