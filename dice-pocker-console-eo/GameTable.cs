namespace PockerDice;

public class GameTable(Player[] players)
{
    public void Start()
    {
        while (true)
        {
            var menu = new Menu(true);
            menu.Options();

            var optionsNumber = menu.OptionsNumber();

            if (optionsNumber == 0)
            {
                return;
            }
            
            players[0] = players[0].RollAll();

            var dicesValue = players[0].DicesValue();

            Console.WriteLine("The values of your dice:");

            foreach (var diceValue in dicesValue)
            {
                Console.WriteLine(diceValue);
            }

            //TODO 
            
            int[] indexes = menu.NumbersDiceToRoll();

            players[0] = players[0].RollDices(indexes);

            dicesValue = players[0].DicesValue();

            Console.WriteLine("The values of your dice:");

            foreach (var diceValue in dicesValue)
            {
                Console.WriteLine(diceValue);
            }

            Console.ReadKey();
        }
    }
}