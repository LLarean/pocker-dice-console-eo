namespace PockerDice;

public record Dice(Random Random, int MaximumValue)
{
    private const int MinimumValue = 1;
    private readonly int _currentValue = MinimumValue;

    private Dice(Random random, int maximumValue, int currentValue) : this(random, maximumValue)
    {
        _currentValue = currentValue;
    }

    public Dice Roll()
    {
        Console.WriteLine("MaximumValue = " + MaximumValue);
        var randomValue = Random.Next(MinimumValue, MaximumValue + 1);
        Console.WriteLine($"Rolled a {_currentValue}");
        return new Dice(Random, MaximumValue, randomValue);
    }

    public int Value()
    {
        return _currentValue;
    }
}