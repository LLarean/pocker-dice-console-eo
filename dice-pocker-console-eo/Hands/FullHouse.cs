namespace PockerDice.Hands;

/// <summary>
/// Represents a FullHouse hand in a dice-based poker game, characterized by a combination
/// in which one value appears exactly three times and another value appears exactly two times
/// <seealso cref="HandType.FullHouse"/>
/// </summary>
/// <remarks>
/// 6 + 6 + 6 + 2 + 2
/// </remarks>
public record FullHouse
{
    private readonly DiceDictionary _diceDictionary;

    /// <summary>
    /// Represents a Full House hand in a dice-based poker game, where one value appears exactly three times
    /// and another value appears exactly two times
    /// </summary>
    public FullHouse(DiceDictionary diceDictionary)
    {
        _diceDictionary = diceDictionary;
    }

    /// <summary>
    /// Determines if the current dice values represent a valid Full House hand in a dice-based poker game
    /// A Full House is defined as having one value appearing exactly three times
    /// and another value appearing exactly two times
    /// </summary>
    /// <returns>
    /// True if the dice values represent a valid Full House, otherwise false
    /// </returns>
    public bool IsValid()
    {
        var haveTwoCards = false;
        var haveThreeCards = false;
        
        foreach (var dice in _diceDictionary.Content())
        {
            if (dice.Value == 2)
            {
                haveTwoCards = true;
            }
            if (dice.Value == 3)
            {
                haveThreeCards = true;
            }
        }
        
        return haveTwoCards && haveThreeCards;
    }
}