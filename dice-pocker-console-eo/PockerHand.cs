namespace PockerDice;

public class PockerHand
{
    private Dice[] _dices;

    public PockerHand(Dice[] dices)
    {
        _dices = dices;
    }
    
    public HandType Type()
    {
        List<int> diceValues = new();
        
        foreach (var dice in _dices)
        {
            diceValues.Add(dice.Value());
        }

        var diceDictionary = new DiceDictionary(diceValues);
        
        if (diceDictionary.HaveFive()) return HandType.FiveKind;
        if (diceDictionary.HaveFour()) return HandType.FourKind;

        if (diceDictionary.HaveThreeAndTwo()) return HandType.FullHouse;
        
        if (diceDictionary.HaveStraight()) return HandType.Straight;
        
        if (diceDictionary.HaveTwoAndTwo()) return HandType.TwoPair;
        
        if (diceDictionary.HaveTwo()) return HandType.OnePair;
        
        return HandType.Bust;
    }

    private bool FiveKindStatus(List<int> diceValues)
    {
        var value = diceValues.FirstOrDefault();
        return diceValues.All(t => value == t);
    }
}