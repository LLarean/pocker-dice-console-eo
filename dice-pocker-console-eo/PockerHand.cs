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
        
        if (new FiveKind(_diceValues).IsValid()) return HandType.FiveKind;
        if (new FourKind(_diceValues).IsValid()) return HandType.FourKind;

        if (new FullHouse(_diceValues).IsValid()) return HandType.FullHouse;
        
        if (new Straight(_diceValues).IsValid()) return HandType.Straight;
        
        if (new TwoPair(_diceValues).IsValid()) return HandType.TwoPair;
        
        if (new OnePair(_diceValues).IsValid()) return HandType.OnePair;
        
        return HandType.Bust;
    }
}