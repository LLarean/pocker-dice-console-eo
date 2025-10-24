using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class FiveKindTests
{
    [Test]
    [TestCase(new[]{1, 1, 1, 1, 1})]
    [TestCase(new[]{3, 3, 3, 3, 3})]
    [TestCase(new[]{6, 6, 6, 6, 6})]
    public void IsValid_AllValuesIdentical_IsTrue(int[] diceValues)
    {
        var fiveKind = new FiveKind(diceValues);
        
        Assert.IsTrue(fiveKind.IsValid());
    }
    
    [Test]
    [TestCase(new[]{1, 2, 3, 4, 5})]
    [TestCase(new[]{1, 2, 1, 1, 1})]
    [TestCase(new[]{1, 1, 1, 5, 1})]
    public void IsValid_NotAllValuesIdentical_IsFalse(int[] diceValues)
    {
        var fiveKind = new FiveKind(diceValues);
        
        Assert.IsFalse(fiveKind.IsValid());
    }
}