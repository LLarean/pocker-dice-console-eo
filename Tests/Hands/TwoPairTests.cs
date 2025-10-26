using PockerDice;
using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class TwoPairTests
{
    [Test]
    [TestCase(new[]{1, 1, 2, 2, 3})]
    [TestCase(new[]{6, 6, 2, 2, 3})]
    [TestCase(new[]{6, 4, 4, 2, 6})]
    public void IsValid_HandContainsTwoPairs_IsTrue(int[] diceValues)
    {
        var diceDictionary = new DiceDictionary(diceValues);
        var twoPair = new TwoPair(diceDictionary);
        
        Assert.IsTrue(twoPair.IsValid());
    }
    
    [Test]
    [TestCase(new[]{1, 2, 3, 4, 5})]
    [TestCase(new[]{2, 2, 4, 5, 6})]
    [TestCase(new[]{2, 3, 4, 3, 6})]
    public void IsValid_HandNotContainsTwoPairs_IsFalse(int[] diceValues)
    {
        var diceDictionary = new DiceDictionary(diceValues);
        var twoPair = new TwoPair(diceDictionary);
        
        Assert.IsFalse(twoPair.IsValid());
    }
}