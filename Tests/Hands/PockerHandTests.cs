using PockerDice;
using PockerDice.Hands;

namespace Tests;

[TestFixture]
public class PockerHandTests
{
    [Test]
    [TestCase(new[]{1, 1, 1, 1, 1}, HandType.FiveKind)]
    [TestCase(new[]{1, 1, 1, 1, 2}, HandType.FourKind)]
    [TestCase(new[]{1, 1, 1, 2, 2}, HandType.FullHouse)]
    [TestCase(new[]{1, 2, 3, 4, 5}, HandType.Straight)]
    [TestCase(new[]{1, 1, 3, 3, 5}, HandType.TwoPair)]
    [TestCase(new[]{1, 1, 3, 4, 5}, HandType.OnePair)]
    [TestCase(new[]{1, 2, 3, 4, 6}, HandType.Bust)]
    public void Type_PassingValidArray_ArrayCorrespondsType(int[] diceValues, HandType handType)
    {
        var pockerHand = new PockerHand(diceValues);
        
        Assert.IsTrue(pockerHand.Type() == handType);
    }
}