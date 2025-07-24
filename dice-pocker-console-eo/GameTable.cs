namespace PockerDice;

public class GameTable
{
    public void Start()
    {
        var random = new Random();
        var dices = new Dices(random, 6).Content();
        var player = new Player(dices);

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

        player = player.RollDices(indexes);

        dicesValue = player.GetDicesValue();

        Console.WriteLine("The values of your dice:");

        foreach (var diceValue in dicesValue)
        {
            Console.WriteLine(diceValue);
        }

        Console.ReadKey();
    }
}