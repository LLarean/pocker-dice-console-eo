// See https://aka.ms/new-console-template for more information

using PockerDice;

Console.WriteLine("Hello, World!");

var random = new Random();

var dices = new List<Dice>()
{
    new(random, 6),
    new(random, 6)
};
        
var player1 = new Player(new CurrentPlayer(), dices.ToArray());

player1 = player1.Turn();