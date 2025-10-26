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
        var dictionary = new Dictionary<int, int>()
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
            var diceCount = dictionary[diceValue];
            diceCount++;
            dictionary[diceValue] = diceCount;
        }
        
        return dictionary;
    }
}