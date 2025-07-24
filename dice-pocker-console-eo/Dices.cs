namespace PockerDice;

public class Dices(Random random, int maximumValue)
{
    public Dice[] Content()
    {
        var dices = new Dice[]
        {
            new(random, maximumValue),
            new(random, maximumValue),
            new(random, maximumValue),
            new(random, maximumValue),
            new(random, maximumValue)
        };
    
        return dices;
    }
}