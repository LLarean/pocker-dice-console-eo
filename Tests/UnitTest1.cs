namespace Tests;

public class Tests
{
    [Test]
    public void Value_TwoNumbers_ReturnsSum()
    {
        var dice = new Dice(6);
        var result = dice.Value();
        Assert.True(result == 0);
    }
}