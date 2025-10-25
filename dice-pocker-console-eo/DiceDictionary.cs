namespace PockerDice;

public record DiceDictionary
{
    private readonly int[] _diceValues;

    public DiceDictionary(int[] diceValues)
    {
        _diceValues = diceValues;
    }
    
    public Dictionary<int, int> Content()
    {
        var result = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 0},
            {3, 0},
            {4, 0},
            {5, 0},
            {6, 0},
        };

        foreach (var diceValue in _diceValues)
        {
            var diceCount = result[diceValue];
            diceCount++;
            result[diceValue] = diceCount;
        }
        
        return result;
    }
}