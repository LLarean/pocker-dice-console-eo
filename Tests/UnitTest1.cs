using PockerDice;

namespace Tests;

public class DiceTests
{
    [Test]
    [TestCase(4)] // D4
    [TestCase(6)] // D6
    [TestCase(20)] // D20
    public void Constructor_DifferentMaximumValue_DoesNotThrow(int maximumValue)
    {
        var random = new Random();
        
        Assert.DoesNotThrow(() => new Dice(random, maximumValue));
    }

    [Test]
    [TestCase(4)] // D4
    [TestCase(6)] // D6
    [TestCase(20)] // D20
    public void Value_DifferentMaximumValue_CurrentValue1(int maximumValue)
    {
        var random = new Random();
        var dice = new Dice(random, maximumValue);

        Assert.That(dice.Value(), Is.EqualTo(1));
    }

    [Test]
    public void Roll_AnyNumberAttempts_NeverExceedsMaximumValue()
    {
        var minimumValue = 1;
        var maximumValue = 6;

        var random = new Random();
        var dice = new Dice(random, maximumValue);

        for (int i = 0; i < 1000; i++)
        {
            var newDice = dice.Roll();
            Assert.That(newDice.Value(), Is.InRange(minimumValue, maximumValue));
        }
    }

    [Test]
    public void Roll_WithRealRandom_ProducesDifferentValues()
    {
        var random = new Random();
        var dice = new Dice(random, 6);
        var values = new HashSet<int>();

        for (int i = 0; i < 100; i++)
        {
            values.Add(dice.Roll().Value());
        }

        Assert.That(values.Count, Is.GreaterThan(1));
    }

    [Test]
    public void Dice_IsImmutable()
    {
        var random = new Random();
        var dice1 = new Dice(random, 6);
        var dice2 = dice1.Roll();

        Assert.That(dice1.Value(), Is.Not.EqualTo(dice2.Value()));
        Assert.That(dice1, Is.Not.SameAs(dice2));
    }
}