namespace PockerDice.Hands;

/// <summary>
/// Represents a FullHouse hand in a dice-based poker game, characterized by a combination
/// in which one value appears exactly three times and another value appears exactly two times
/// 6 + 6 + 6 + 2 + 2
/// <seealso cref="HandType.FullHouse"/>
/// </summary>
public record FullHouse
{
    private readonly int[] _diceValues;

    /// <summary>
    /// Accepts a collection of dice values
    /// </summary>
    public FullHouse(int[] diceValues)
    {
        _diceValues = diceValues;
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
        var diceDictionary = new Dictionary<int, int>();

        foreach (var diceValue in _diceValues)
        {
            if (diceDictionary.ContainsKey(diceValue))
            {
                var diceNumber = diceDictionary[diceValue];
                diceNumber++;
                diceDictionary[diceValue] = diceNumber;
            }
            else
            {
                diceDictionary.Add(diceValue, 1);
            }
        }
        
        var two = false;
        var three = false;
        
        foreach (var dice in diceDictionary)
        {
            if (dice.Value == 2)
            {
                two = true;
            }
            if (dice.Value == 3)
            {
                three = true;
            }
        }
        
        return two && three;
    }
}