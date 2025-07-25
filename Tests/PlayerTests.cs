using PockerDice;

namespace Tests;

public class PlayerTests
{
    private Dice[] _dices;
    private Player _player;

    [SetUp]
    public void SetUp()
    {
        _dices =
        [
            new Dice(new Random(), 6),
            new Dice(new Random(), 6),
            new Dice(new Random(), 6),
            new Dice(new Random(), 6),
            new Dice(new Random(), 6)
        ];

        _player = new Player(_dices);
    }

    [Test]
    public void RollAll_GeneratesDifferentValues()
    {
        var values = _player.RollAll().DicesValue();

        Assert.That(values, Has.Some.Not.EqualTo(values[0]));
    }

    [Test]
    public void RollDices_GeneratesDifferentValues()
    {
        var indexes = new[] { 0, 2, 4 };
        var values = _player.RollDices(indexes).DicesValue();

        Assert.That(values, Has.Some.Not.EqualTo(values[0]));
    }

    [Test]
    public void GetDicesValue_ReturnsCorrectValues()
    {
        var values = _player.DicesValue();

        Assert.That(values, Has.Length.EqualTo(_dices.Length));
        Assert.That(values, Has.All.InRange(1, 6));
    }
    
    [Test]
    public void RollAll_PlayerIsImmutable()
    {
        var random = new Random();

        var dices = new List<Dice>()
        {
            new(random, 6),
        };
        
        var player1 = new Player(dices.ToArray());
        var player2 = player1.RollAll();

        Assert.That(player1, Is.Not.SameAs(player2));
    }
    
    [Test]
    public void RollDices_PlayerIsImmutable()
    {
        var random = new Random();

        var dices = new List<Dice>()
        {
            new(random, 6),
        };
        
        var player1 = new Player(dices.ToArray());
        var player2 = player1.RollDices([0]);

        Assert.That(player1, Is.Not.SameAs(player2));
    }
}