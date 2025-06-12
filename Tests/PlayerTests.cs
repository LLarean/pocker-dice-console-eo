using PockerDice;

namespace Tests;

public class PlayerTests
{
    [Test]
    public void Player_IsImmutable()
    {
        var random = new Random();

        var dices = new List<Dice>()
        {
            new(random, 6),
            new(random, 6)
        };
        
        var player1 = new Player(dices.ToArray());
        var player2 = player1.RollAll();

        // Assert.That(player1.GetDicesValue(), Is.Not.EqualTo(player2.GetDicesValue()));
        Assert.That(player1, Is.Not.SameAs(player2));
    }
}