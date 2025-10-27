using PockerDice;

var random = new Random();
var dices = new Deck(random, 6).Dices();

var players = new Player[1];
var player = new Player(dices);
players[0] = player;

GameTable gameTable = new GameTable(players);

gameTable.Start();