namespace PockerDice;

public record GameTable
{
    private readonly Player[] _players;

    public GameTable(Player[] players)
    {
        _players = players;
    }
    
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

            _players[0] = _players[0].RollAll();

            var dicesValue = _players[0].DicesValue();

            Console.WriteLine("The values of your dice:");

            foreach (var diceValue in dicesValue)
            {
                Console.WriteLine(diceValue);
            }

            int[] indexes = menu.NumbersDiceToRoll();

            _players[0] = _players[0].RollDices(indexes);

            dicesValue = _players[0].DicesValue();

            Console.WriteLine("The values of your dice:");

            foreach (var diceValue in dicesValue)
            {
                Console.WriteLine(diceValue);
            }
            
            var pockerHand = new PockerHand(dicesValue);
            Console.WriteLine("Pocker Hand: " + pockerHand.Type());

            Console.ReadKey();
        }
    }
}