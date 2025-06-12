namespace PockerDice;

public record Player : IPlayer
{
    private readonly IPlayer _player;
    private readonly Dice[] _dices;

    public Player(IPlayer player, Dice[] dices)
    {
        _player = player;
        _dices = dices;
    }

    public Player Turn()
    {
        // _player.Turn();
        
        foreach (var dice in _dices)
        {
            dice.Roll();
        }

        return new Player(_player, _dices);
    }

    public int[] GetDicesValue()
    {
        List<int> values = new();
        
        foreach (var dice in _dices)
        {
            values.Add(dice.Value());
        }
        
        return values.ToArray();
    }
}