namespace PockerDice.Hands;

/// <summary>
/// Represents a poker dice hand of type "Straight"
/// <seealso cref="HandType.Straight"/>
/// </summary>
/// <remarks>
/// 1 + 2 + 3 + 4 + 5
/// </remarks>
public record Straight
{
    private readonly int[] _diceValues;

    /// <summary>
    /// Represents a poker dice hand classified as a "Straight"
    /// A "Straight" hand is determined based on specific criteria
    /// involving the sequential presence of dice values
    /// </summary>
    public Straight(int[] diceValues)
    {
        _diceValues = diceValues;
    }

    /// <summary>
    /// Determines whether the current poker dice hand qualifies as a "Straight"
    /// A "Straight" requires sequential dice values according to predefined rules
    /// </summary>
    /// <returns>
    /// True if the hand meets the criteria for a "Straight"; otherwise, false
    /// </returns>
    public bool IsValid()
    {
        var diceDictionary = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 0},
            {3, 0},
            {4, 0},
            {5, 0},
            {6, 0},
        };

        foreach (var diceValue in _diceValues)
        {
            if (diceDictionary.ContainsKey(diceValue))
            {
                var diceNumber = diceDictionary[diceValue];
                diceNumber++;
                diceDictionary[diceValue] = diceNumber;
            }
        }

        if (diceDictionary[2] == 0) return false;
        if (diceDictionary[3] == 0) return false;
        if (diceDictionary[4] == 0) return false;
        if (diceDictionary[5] == 0) return false;
        
        return true;
    }
}