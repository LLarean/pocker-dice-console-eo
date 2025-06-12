// See https://aka.ms/new-console-template for more information

using PockerDice;

var random = new Random();

var dices = new List<Dice>()
{
    new(random, 6),
    new(random, 6),
    new(random, 6),
    new(random, 6),
    new(random, 6)
};

var player = new Player(dices.ToArray());

Console.WriteLine("Press any key to roll the dice");
Console.ReadKey();

player = player.RollAll();

var dicesValue = player.GetDicesValue();

Console.WriteLine("The values of your dice:");

foreach (var diceValue in dicesValue)
{
    Console.WriteLine(diceValue);
}

Console.WriteLine("\nEnter the index of the dice you want to roll (separated by a space)");
var input = Console.ReadLine();

int[] indexes = input.Split(' ')
    .Select(int.Parse)
    .ToArray();

player = player.RerollDices(indexes);

dicesValue = player.GetDicesValue();

Console.WriteLine("The values of your dice:");

foreach (var diceValue in dicesValue)
{
    Console.WriteLine(diceValue);
}

Console.ReadKey();