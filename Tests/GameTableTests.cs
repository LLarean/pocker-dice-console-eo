using PockerDice;

namespace Tests;

[TestFixture]
public class GameTableTests
{
    [Test]
    public void Constructor_ShouldInitializePlayers()
    {
        var random = new Random();
        var dices = new Deck(random, 6).Dices();
        
        var player = new Player(dices);
        var players = new Player[1];
        players[0] = player;

        var gameTable = new GameTable(players);

        Assert.IsNotNull(gameTable);
    }
}