using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class StraightTests
{
    [Test]
    [TestCase(new[]{1, 2, 3, 4, 5})]
    [TestCase(new[]{2, 3, 4, 5, 6})]
    public void IsValid_HandMeetsCriteriaStraight_IsTrue(int[] diceValues)
    {
        var straight = new Straight(diceValues);
        
        Assert.IsTrue(straight.IsValid());
    }
    
    [Test]
    [TestCase(new[]{1, 2, 1, 4, 6})]
    [TestCase(new[]{1, 2, 1, 1, 1})]
    [TestCase(new[]{1, 3, 1, 3, 1})]
    public void IsValid_HandNotMeetsCriteriaStraight_IsFalse(int[] diceValues)
    {
        var straight = new Straight(diceValues);
        
        Assert.IsFalse(straight.IsValid());
    }
}