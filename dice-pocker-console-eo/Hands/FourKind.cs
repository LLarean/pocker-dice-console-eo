namespace PockerDice.Hands;

/// <summary>
/// It is a type of combination in poker dice, in which only four dice show the same value, categorized as a Four Kind
/// 3 + 3 + 3 + 3 + 1
/// <seealso cref="HandType.FourKind"/>
/// </summary>
public record FourKind
{
    private readonly int[] _diceValues;

    /// <summary>
    /// Accepts a collection of dice values
    /// </summary>
    public FourKind(int[] diceValues)
    {
        _diceValues = diceValues;
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

        foreach (var dice in diceDictionary)
        {
            if (dice.Value == 4)
            {
                return true;
            }
        }
        
        return false;
    }
}