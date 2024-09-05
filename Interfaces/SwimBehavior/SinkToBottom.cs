namespace StrategyPattern.Interfaces.SwimBehavior;

public class SinkToBottom : SwimBehavior
{
    public void Swim()
    {
        Console.WriteLine("I'm sinking to the bottom");
    }
}