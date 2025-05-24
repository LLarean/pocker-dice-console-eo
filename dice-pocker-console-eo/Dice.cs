namespace PockerDice;

public class Dice(Random random, int maximumValue)
{
    private const int MinimumValue = 1;
    private readonly int _currentValue = MinimumValue;

    private Dice(Random random, int maximumValue, int currentValue) : this(random, maximumValue)
    {
        _currentValue = currentValue;
    }

    public Dice Roll()
    {
        var randomValue = random.Next(MinimumValue, maximumValue + 1);
        return new Dice(random, maximumValue, randomValue);
    }

    public int Value()
    {
        return _currentValue;
    }
}