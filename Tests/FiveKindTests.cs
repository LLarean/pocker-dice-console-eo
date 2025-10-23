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
    public void IsValid_NotAllValuesIdentical_IsFalse()
    {
        int[] diceValues = { 1, 1, 1, 1, 2 };
        var fiveKind = new FiveKind(diceValues);
        
        Assert.IsFalse(fiveKind.IsValid());
    }
}