namespace PockerDice;

public class PockerHand(Dice[] dices)
{
    private readonly Dice[] _dices = dices;

    public HandType Type()
    {
        return HandType.FourKind;
    }
}