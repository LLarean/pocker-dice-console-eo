namespace PockerDice;

public class PockerHand
{
    private Dice[] _dices;

    public PockerHand(Dice[] dices)
    {
        _dices = dices;
    }
    
    public HandType Type()
    {
        List<int> diceValues = new();
        
        foreach (var dice in _dices)
        {
            diceValues.Add(dice.Value());
        }

        if (FiveKindStatus(diceValues)) return HandType.FiveKind;
        
        if (FourKindStatus(diceValues)) return HandType.FourKind;
        
        return HandType.Bust;
    }

    private bool FiveKindStatus(List<int> diceValues)
    {
        var value = diceValues.FirstOrDefault();
        return diceValues.All(t => value == t);
    }
    
    private bool FourKindStatus(List<int> diceValues)
    {
        var value = diceValues.FirstOrDefault();
        
        for (int i = 0; i < diceValues.Count; i++)
        {
            if (value != diceValues[i])
            {
                return false;
            }
        }

        return true;
    }
}