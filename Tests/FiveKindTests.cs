using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class FiveKindTests
{
    [Test]
    public void IsValid_AllValuesIdentical_IsTrue()
    {
        int[] diceValues = { 1, 1, 1, 1, 1 };
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
    
    [Test]
    public void IsValid_DiceValuesIsNull_ThrowsException()
    {
        var fiveKind = new FiveKind(null);
        
        Assert.That(() => fiveKind.IsValid(), Throws.Exception);
    }
    
    [Test]
    [TestCase(new int[]{})]
    [TestCase(new[]{1})]
    [TestCase(new[]{1, 2, 3, 4})]
    [TestCase(new[]{1, 2, 3, 4, 5, 6})]
    public void IsValid_DiceValuesLengthNotFive_ThrowsException(int[] diceValues)
    {
        var fiveKind = new FiveKind(diceValues);
        
        Assert.That(() => fiveKind.IsValid(), Throws.Exception);
    }
}