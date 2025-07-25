using PockerDice;

namespace Tests;

[TestFixture]
public class DeckTests
{
    [Test]
    [TestCase(4)] // D4
    [TestCase(6)] // D6
    [TestCase(20)] // D20
    public void Content_ShouldReturnListWithFiveDices(int maximumValue)
    {
        var random = new Random();
        
        var dices = new Deck(random, maximumValue).Dices();

        Assert.NotNull(dices);
        Assert.That(dices.Length, Is.EqualTo(5));

        for (int i = 0; i < dices.Length; i++)
        {
            Assert.That(dices[i].Value, Is.InRange(1, maximumValue));
        }
    }
}