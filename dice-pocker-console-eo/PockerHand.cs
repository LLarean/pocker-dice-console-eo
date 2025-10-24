using PockerDice.Hands;

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
        var diceDictionary = new DiceDictionary(_diceValues.ToList());
        
        if (diceDictionary.HaveFive()) return HandType.FiveKind;
        if (diceDictionary.HaveFour()) return HandType.FourKind;

        if (diceDictionary.HaveThreeAndTwo()) return HandType.FullHouse;
        
        if (diceDictionary.HaveStraight()) return HandType.Straight;
        
        if (diceDictionary.HaveTwoAndTwo()) return HandType.TwoPair;
        
        if (diceDictionary.HaveTwo()) return HandType.OnePair;
        
        return HandType.Bust;
    }
}