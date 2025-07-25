namespace PockerDice;

public class GameTable(Player[] players)
{
    public void Start()
    {
        new Menu(true).Options();
        
        Console.ReadKey();

        players[0] = players[0].RollAll();

        var dicesValue = players[0].GetDicesValue();

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

        players[0] = players[0].RollDices(indexes);

        dicesValue = players[0].GetDicesValue();

        Console.WriteLine("The values of your dice:");

        foreach (var diceValue in dicesValue)
        {
            Console.WriteLine(diceValue);
        }

        Console.ReadKey();
    }
}