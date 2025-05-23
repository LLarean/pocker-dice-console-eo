public class Dice
{
    private readonly int _maximumValue;
    private readonly int _currentValue;

    public Dice(int maximumValue)
    {
        _maximumValue = maximumValue;
    }
    
    public Dice(int maximumValue, int currentValue)
    {
        _maximumValue = maximumValue;
        _currentValue = currentValue;
    }

    public Dice Roll()
    {
        Random random = new Random();
        var randomValue = random.Next(_maximumValue + 1);
        return new Dice(_maximumValue, randomValue);
    }

    public int Value()
    {
        return _currentValue;
    }
}