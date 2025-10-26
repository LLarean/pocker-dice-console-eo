namespace PockerDice.Hands;

/// <summary>
/// Represents a poker hand that checks if a set of dice values contains exactly one pair
/// <seealso cref="HandType.OnePair"/>
/// </summary>
/// <remarks>
/// 3 + 3 + 6 + 5 + 2
/// </remarks>
public class OnePair
{
    private readonly DiceDictionary _diceDictionary;

    /// <summary>
    /// Represents a poker hand that verifies if an array of dice values contains exactly one pair
    /// </summary>
    public OnePair(DiceDictionary diceDictionary)
    {
        _diceDictionary = diceDictionary;
    }

    /// <summary>
    /// Determines whether the current dice values represent a hand containing exactly one pair
    /// </summary>
    /// <returns>
    /// A boolean value indicating whether the dice values contain exactly one pair
    /// Returns true if there is exactly one pair, otherwise false
    /// </returns>
    public bool IsValid()
    {
        foreach (var dice in _diceDictionary.Content())
        {
            if (dice.Value == 2)
            {
                return true;
            }
        }
        
        return false;
    }
}