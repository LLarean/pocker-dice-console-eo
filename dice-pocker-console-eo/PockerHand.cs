namespace PockerDice;

public class PockerHand
{
    private int[] _diceValues;

    public PockerHand(int[] diceValues)
    {
        _diceValues = diceValues;
    }
    
    public HandType Type()
    {
        List<int> diceValues = new();
        
        var diceDictionary = new DiceDictionary(diceValues);
        
        if (diceDictionary.HaveFive()) return HandType.FiveKind;
        if (diceDictionary.HaveFour()) return HandType.FourKind;

        if (diceDictionary.HaveThreeAndTwo()) return HandType.FullHouse;
        
        if (diceDictionary.HaveStraight()) return HandType.Straight;
        
        if (diceDictionary.HaveTwoAndTwo()) return HandType.TwoPair;
        
        if (diceDictionary.HaveTwo()) return HandType.OnePair;
        
        return HandType.Bust;
    }
}