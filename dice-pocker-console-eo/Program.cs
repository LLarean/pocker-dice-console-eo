// See https://aka.ms/new-console-template for more information

using PockerDice;

var random = new Random();

var dices1 = new List<Dice>()
{
    new(random, 6),
    new(random, 6),
    new(random, 6),
    new(random, 6),
    new(random, 6)
};

var player1 = new Player(dices1.ToArray());

// var dices2 = new List<Dice>()
// {
//     new(random, 6),
//     new(random, 6),
//     new(random, 6),
//     new(random, 6),
//     new(random, 6)
// };
//
// var player2 = new Player(new CurrentPlayer(), dices2.ToArray());


Console.WriteLine("Roll the dice - 1\nExit - 2");
var value = Console.ReadLine();

var command = int.Parse(value);

if (command == 1)
{
    player1 = player1.RollAll();
    // player2 = player2.Turn();
}

var dicesValue1 = player1.GetDicesValue();
// var dicesValue2 = player2.GetDicesValue();

Console.Write("Your dices:");

for (int i = 0; i < dicesValue1.Length; i++)
{
    Console.Write(" " + dicesValue1[i]);
}

// Console.Write("\nEnemy dices:");
//
// for (int i = 0; i < dicesValue2.Length; i++)
// {
//     Console.Write(" " + dicesValue2[i]);
// }

Console.WriteLine("\nPRESS ANY KEY");
Console.ReadKey();