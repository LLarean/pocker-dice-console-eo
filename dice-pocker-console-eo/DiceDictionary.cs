namespace PockerDice;

public record DiceDictionary
{
    private readonly List<int> _diceValues;

    public DiceDictionary(List<int> diceValues)
    {
        _diceValues = diceValues;
    }

    public int DiceWithOneCount()
    {
        var diceDictionary = Content();

        return diceDictionary[0];
        // Content
    }

    public bool HaveFive()
    {
        var diceDictionary = Content();
        
        for (int i = 0; i < diceDictionary.Count; i++)
        {
            if (diceDictionary[i] == 5)
            {
                return true;
            }
        }

        return false;
    }
    
    public bool HaveFour()
    {
        var diceDictionary = Content();
        
        for (int i = 0; i < diceDictionary.Count; i++)
        {
            if (diceDictionary[i] == 4)
            {
                return true;
            }
        }

        return false;
    }
    
    public bool HaveThreeAndTwo()
    {
        var diceDictionary = Content();

        var two = false;
        var three = false;
        
        for (int i = 0; i < diceDictionary.Count; i++)
        {
            if (diceDictionary[i] == 2)
            {
                two = true;
            }
            
            if (diceDictionary[i] == 3)
            {
                three = true;
            }
        }

        return two && three;
    }
    
    public bool HaveStraight()
    {
        return false;
    }
    
    public bool HaveTwoAndTwo()
    {
        var diceDictionary = Content();

        var firstTwo = false;
        var secondTwo = false;
        
        for (int i = 0; i < diceDictionary.Count; i++)
        {
            if (diceDictionary[i] == 2 && firstTwo == true)
            {
                secondTwo = true;
            }

            if (diceDictionary[i] == 2 && firstTwo == false)
            {
                firstTwo = true;
            }
        }

        return firstTwo && secondTwo;
    }
    
    public bool HaveTwo()
    {
        var diceDictionary = Content();

        for (int i = 0; i < diceDictionary.Count; i++)
        {
            if (diceDictionary[i] == 2)
            {
                return true;
            }
        }

        return false;
    }
    
    private Dictionary<int, int> Content()
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