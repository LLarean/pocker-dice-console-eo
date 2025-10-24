using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class FourKindTests
{
    [Test]
    [TestCase(new[]{1, 1, 1, 1, 2})]
    [TestCase(new[]{2, 3, 3, 3, 3})]
    [TestCase(new[]{6, 6, 3, 6, 6})]
    public void IsValid_FourNumbersAreSame_IsTrue(int[] diceValues)
    {
        var fourKind = new FourKind(diceValues);
        
        Assert.IsTrue(fourKind.IsValid());
    }
    
    [Test]
    [TestCase(new[]{1, 2, 3, 4, 5})]
    [TestCase(new[]{1, 2, 2, 1, 1})]
    [TestCase(new[]{1, 1, 1, 5, 5})]
    public void IsValid_NoFourNumbersAreSame_IsFalse(int[] diceValues)
    {
        var fourKind = new FourKind(diceValues);
        
        Assert.IsFalse(fourKind.IsValid());
    }
}