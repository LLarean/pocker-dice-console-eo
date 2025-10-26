using PockerDice;

namespace Tests;

[TestFixture]
public class DiceDictionaryTests
{
    [Test]
    [TestCase(new[]{1, 1, 1, 1, 1})]
    [TestCase(new[]{2, 2, 2, 2, 2})]
    [TestCase(new[]{3, 3, 3, 3, 3})]
    [TestCase(new[]{4, 4, 4, 4, 4})]
    [TestCase(new[]{5, 5, 5, 5, 5})]
    [TestCase(new[]{6, 6, 6, 6, 6})]
    public void Content_ArrayContainsFiveKind_QuantityIsCorrect(int[] diceValues)
    {
        var dices = new DiceDictionary(diceValues).Content();
        
        Assert.IsTrue(dices[diceValues[0]] == 5);
    }
    
    [Test]
    [TestCase(new[]{1, 1, 1, 1, 2})]
    [TestCase(new[]{2, 2, 2, 2, 3})]
    [TestCase(new[]{3, 3, 3, 3, 4})]
    [TestCase(new[]{4, 4, 4, 4, 5})]
    [TestCase(new[]{5, 5, 5, 5, 6})]
    [TestCase(new[]{6, 6, 6, 6, 1})]
    public void Content_ArrayContainsFourKind_QuantityIsCorrect(int[] diceValues)
    {
        var dices = new DiceDictionary(diceValues).Content();
        var key = diceValues[0];
        
        Assert.IsTrue(dices[key] == 4);
    }
    
    [Test]
    [TestCase(new[]{1, 2, 3, 4, 5})]
    [TestCase(new[]{6, 2, 3, 4, 5})]
    public void Content_ArrayContainsOnePair_QuantityIsCorrect(int[] diceValues)
    {
        var dices = new DiceDictionary(diceValues).Content();

        foreach (var dice in dices)
        {
            Assert.IsTrue(dice.Value <= 1);
        }
    }
}