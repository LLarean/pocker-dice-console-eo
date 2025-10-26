namespace PockerDice.Hands;

/// <summary>
/// Represents a hand of dice that qualifies as a "Two Pair" in Poker Dice
/// <seealso cref="HandType.TwoPair"/>
/// </summary>
/// <remarks>
/// 5 + 5 + 2 + 2 + 1
/// </remarks>
public class TwoPair
{
    private readonly DiceDictionary _diceDictionary;
    
    /// <summary>
    /// Represents a hand in the Poker Dice game identified as "Two Pair"
    /// This class determines whether a given hand of dice satisfies the "Two Pair" condition
    /// </summary>
    public TwoPair(DiceDictionary diceDictionary)
    {
        _diceDictionary = diceDictionary;
    }

    /// <summary>
    /// Determines whether the current hand of dice satisfies the "Two Pair" condition in Poker Dice
    /// </summary>
    /// <returns>
    /// True if the hand contains exactly two pairs of dice with the same value; otherwise, false
    /// </returns>
    public bool IsValid()
    {
        var haveFirstPair = false;
        var haveSecondPair = false;
        
        foreach (var dice in _diceDictionary.Content())
        {
            if (dice.Value == 2 && haveFirstPair == false)
            {
                haveFirstPair = true;
            }
            else if (dice.Value == 2)
            {
                haveSecondPair = true;
            }
        }
        
        return haveFirstPair && haveSecondPair;
    }
}