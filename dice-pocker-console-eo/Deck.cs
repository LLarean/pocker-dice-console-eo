namespace PockerDice;

public class Deck(Random random, int maximumValue)
{
    public Dice[] Dices()
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