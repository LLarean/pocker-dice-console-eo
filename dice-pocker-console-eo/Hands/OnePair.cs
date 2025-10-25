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
    private readonly int[] _diceValues;

    /// <summary>
    /// Represents a poker hand that verifies if an array of dice values contains exactly one pair
    /// </summary>
    public OnePair(int[] diceValues)
    {
        _diceValues = diceValues;
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

        var firstPair = false;
        var secondPair = false;
        
        foreach (var dice in diceDictionary)
        {
            if (dice.Value == 2 && firstPair == false)
            {
                firstPair = true;
            }
            else if (dice.Value == 2)
            {
                secondPair = true;
            }
        }
        
        return firstPair && !secondPair;
    }
}