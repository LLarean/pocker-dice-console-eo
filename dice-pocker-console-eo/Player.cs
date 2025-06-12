namespace PockerDice;

public record Player : IPlayer
{
    private readonly Dice[] _dices;

    public Player(Dice[] dices)
    {
        _dices = dices;
    }

    public Player RollAll()
    {
        for (int i = 0; i < _dices.Length; i++)
        {
            _dices[i] = _dices[i].Roll();
        }

        return new Player(_dices);
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