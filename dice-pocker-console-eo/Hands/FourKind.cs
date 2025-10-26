namespace PockerDice.Hands;

/// <summary>
/// It is a type of combination in poker dice, in which only four dice show the same value, categorized as a Four Kind
/// <seealso cref="HandType.FourKind"/>
/// </summary>
/// <remarks>
/// 3 + 3 + 3 + 3 + 1
/// </remarks>
public record FourKind
{
    private readonly DiceDictionary _diceDictionary;

    /// <summary>
    /// Represents the Four of a Kind poker dice hand, which consists of exactly four dice showing the same value
    /// </summary>
    public FourKind(DiceDictionary diceDictionary)
    {
        _diceDictionary = diceDictionary;
    }

    /// <summary>
    /// Validates whether the dice values form a Four of a Kind hand in Poker Dice
    /// </summary>
    /// <returns>
    /// True if the hand includes exactly four dice of the same value; otherwise, false
    ///
    /// </returns>
    public bool IsValid()
    {
        foreach (var dice in _diceDictionary.Content())
        {
            if (dice.Value == 4)
            {
                return true;
            }
        }
        
        return false;
    }
}