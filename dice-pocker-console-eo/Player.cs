﻿namespace PockerDice;

public record Player
{
    private readonly Dice[] _dices;

    public Player(Dice[] dices)
    {
        _dices = dices;
    }

    public Player RollAll()
    {
        int[] indexes = Enumerable.Range(0, _dices.Length).ToArray();
        Roll(indexes);
        return new Player(_dices);
    }

    public Player RollDices(int[] indexes)
    {
        Roll(indexes);
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

    private void Roll(int[] indexes)
    {
        foreach (var index in indexes)
        {
            _dices[index] = _dices[index].Roll();
        }
    }
}