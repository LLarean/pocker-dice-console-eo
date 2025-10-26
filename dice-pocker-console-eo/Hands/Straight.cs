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
    private readonly DiceDictionary _diceDictionary;

    /// <summary>
    /// Represents a poker dice hand classified as a "Straight"
    /// A "Straight" hand is determined based on specific criteria
    /// involving the sequential presence of dice values
    /// </summary>
    public  Straight(DiceDictionary diceDictionary)
    {
        _diceDictionary = diceDictionary;
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
        var diceDictionary = _diceDictionary.Content();
        
        if (diceDictionary[2] == 0) return false;
        if (diceDictionary[3] == 0) return false;
        if (diceDictionary[4] == 0) return false;
        if (diceDictionary[5] == 0) return false;

        if (diceDictionary[1] == 0 && diceDictionary[6] == 0) return false;
        
        return true;
    }
}