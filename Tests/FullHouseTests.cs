using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class FullHouseTests
{
    [Test]
    [TestCase(new[]{1, 1, 1, 2, 2})]
    [TestCase(new[]{2, 2, 1, 1, 1})]
    [TestCase(new[]{6, 6, 3, 3, 6})]
    public void IsValid_ValuesRepresentValidFullHouse_IsTrue(int[] diceValues)
    {
        var fullHouse = new FullHouse(diceValues);
        
        Assert.IsTrue(fullHouse.IsValid());
    }
    
    [Test]
    [TestCase(new[]{1, 2, 3, 4, 5})]
    [TestCase(new[]{1, 2, 2, 2, 2})]
    [TestCase(new[]{1, 3, 3, 5, 5})]
    public void IsValid_ValuesRepresentNotValidFullHouse_IsFalse(int[] diceValues)
    {
        var fullHouse = new FullHouse(diceValues);
        
        Assert.IsFalse(fullHouse.IsValid());
    }
}