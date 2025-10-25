namespace PockerDice.Hands;

/// <summary>
/// Represents a hand of dice that qualifies as a "Two Pair" in Poker Dice
/// <seealso cref="HandType.TwoPair"/>
/// </summary>
/// <remarks>
/// 5 + 5 + 2 + 2 + 1
/// </remarks>
public class TwoPair
{
    private readonly int[] _diceValues;

    /// <summary>
    /// Represents a hand in the Poker Dice game identified as "Two Pair"
    /// This class determines whether a given hand of dice satisfies the "Two Pair" condition
    /// </summary>
    public TwoPair(int[] diceValues)
    {
        _diceValues = diceValues;
    }

    /// <summary>
    /// Determines whether the current hand of dice satisfies the "Two Pair" condition in Poker Dice
    /// </summary>
    /// <returns>
    /// True if the hand contains exactly two pairs of dice with the same value; otherwise, false
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
        
        return firstPair && secondPair;
    }
}