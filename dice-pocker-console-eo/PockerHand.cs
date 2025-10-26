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
        var diceDictionary = new DiceDictionary(_diceValues);
        
        if (new FiveKind(diceDictionary).IsValid()) return HandType.FiveKind;
        if (new FourKind(diceDictionary).IsValid()) return HandType.FourKind;

        if (new FullHouse(_diceValues).IsValid()) return HandType.FullHouse;
        
        if (new Straight(_diceValues).IsValid()) return HandType.Straight;
        
        if (new TwoPair(_diceValues).IsValid()) return HandType.TwoPair;
        
        if (new OnePair(_diceValues).IsValid()) return HandType.OnePair;
        
        return HandType.Bust;
    }
}