using PockerDice;
using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class OnePairTests
{
    [Test]
    [TestCase(new[]{1, 1, 2, 3, 4})]
    [TestCase(new[]{1, 2, 6, 6, 3})]
    [TestCase(new[]{2, 1, 3, 5, 5})]
    public void IsValid_HandContainsOnePair_IsTrue(int[] diceValues)
    {
        var diceDictionary = new DiceDictionary(diceValues);
        var onePair = new OnePair(diceDictionary);
        
        Assert.IsTrue(onePair.IsValid());
    }
    
    [Test]
    [TestCase(new[]{1, 2, 3, 4, 5})]
    [TestCase(new[]{5, 4, 3, 1, 6})]
    [TestCase(new[]{2, 4, 1, 3, 6})]
    public void IsValid_HandNotContainsOnePair_IsFalse(int[] diceValues)
    {
        var diceDictionary = new DiceDictionary(diceValues);
        var onePair = new OnePair(diceDictionary);
        
        Assert.IsFalse(onePair.IsValid());
    }
}