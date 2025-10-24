namespace PockerDice.Hands;

/// <summary>
/// Represents a hand type in Poker Dice where all five dice show the same value, categorized as a Five Kind
/// 4 + 4 + 4 + 4 + 4
/// <seealso cref="HandType.FiveKind"/>
/// </summary>
public record FiveKind
{
    private readonly int[] _diceValues;

    /// <summary>
    /// Accepts a collection of dice values
    /// </summary>
    public FiveKind(int[] diceValues)
    {
        _diceValues = diceValues;
    }

    /// <summary>
    /// Determines whether all dice values in the set are of the same value, signifying a successful Five Kind hand
    /// </summary>
    /// <returns>True if all dice values are identical; otherwise, false</returns>
    public bool IsValid()
    {
        var tempValue = int.MinValue;
        
        foreach (var diceValue in _diceValues)
        {
            if (tempValue == int.MinValue)
            {
                tempValue = diceValue;
            }
            else if (tempValue != diceValue)
            {
                return false;
            }
        }

        return true;
    }
}