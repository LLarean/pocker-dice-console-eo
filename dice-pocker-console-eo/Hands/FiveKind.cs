namespace PockerDice.Hands;

/// <summary>
/// Represents a hand type in Poker Dice where all five dice show the same value, categorized as a Five Kind
/// <seealso cref="HandType.FiveKind"/>
/// </summary>
/// <remarks>
/// 4 + 4 + 4 + 4 + 4
/// </remarks>
public record FiveKind
{
    private readonly DiceDictionary _diceDictionary;

    /// <summary>
    /// Represents a specific hand in Poker Dice where all five dice display the same value, categorized as a Five Kind
    /// </summary>
    public FiveKind(DiceDictionary diceDictionary)
    {
        _diceDictionary = diceDictionary;
    }

    /// <summary>
    /// Determines whether all dice values in the set are of the same value, signifying a successful Five Kind hand
    /// </summary>
    /// <returns>
    /// True if all dice values are identical; otherwise, false
    /// </returns>
    public bool IsValid()
    {
        foreach (var dice in _diceDictionary.Content())
        {
            if (dice.Value == 5)
            {
                return true;
            }
        }
        
        return false;
    }
}