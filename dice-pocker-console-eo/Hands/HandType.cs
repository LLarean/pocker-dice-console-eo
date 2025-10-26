namespace PockerDice.Hands;

/// <summary>
/// Defines the various hand types in a Poker Dice game
/// <seealso cref="en.wikipedia.org/wiki/Poker_dice#Probabilities"/>
/// </summary>
public enum HandType
{
    /// <summary>
    /// 4 + 4 + 4 + 4 + 4
    /// </summary>
    FiveKind,

    /// <summary>
    /// 3 + 3 + 3 + 3 + 1
    /// </summary>
    FourKind,

    /// <summary>
    /// 6 + 6 + 6 + 2 + 2
    /// </summary>
    FullHouse,

    /// <summary>
    /// 1 + 2 + 3 + 4 + 5
    /// </summary>
    Straight,
    
    /// <summary>
    /// 5 + 5 + 2 + 2 + 1
    /// </summary>
    TwoPair,
    
    /// <summary>
    /// 3 + 3 + 6 + 5 + 2
    /// </summary>
    OnePair,
    
    /// <summary>
    /// (high card; no pair, no straight)
    /// 1 + 2 + 4 + 5 + 6
    /// </summary>
    Bust,
}