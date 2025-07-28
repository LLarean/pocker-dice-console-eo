namespace PockerDice;

public class Menu(bool isFirstStep)
{
    public void Options()
    {
        Console.WriteLine("Select menu option");
        Console.WriteLine("1 - Roll all your dice");

        if (isFirstStep == false)
        {
            Console.WriteLine("2 - Select dice to roll");
            Console.WriteLine("3 - Skip");
        }
        
        Console.WriteLine("0 - Exit");
    }

    public int OptionsNumber()
    {
        while (true)
        {
            try
            {
                var input = Console.ReadLine();;

                if (int.TryParse(input, out int number) == false)
                {
                    throw new FormatException($"Invalid number format: '{input}'.");
                }

                if (number != 0 && number != 1 && number != 2 && number != 3)
                {
                    throw new ArgumentOutOfRangeException(nameof(number), $"Number must be 0, 1, 2 or 3. Got: {number}");
                }
                
                return number;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Try again.");
            }
        }
    }

    public int[] NumbersDiceToRoll()
    {
        while (true)
        {
            try
            {
                var input = UserInput();
                var parts = SplitInput(input);
                var numbers = ParseAndValidateNumbers(parts);

                return numbers;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}. Try again.");
            }
        }
    }
    
    private string UserInput()
    {
        Console.WriteLine("\nEnter the numbers of dice to roll (separated by a space)");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("Input cannot be empty.");
        }

        return input;
    }

    private string[] SplitInput(string input)
    {
        var parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length == 0)
        {
            throw new ArgumentException("No valid numbers were entered.");
        }

        return parts;
    }

    private int[] ParseAndValidateNumbers(string[] parts)
    {
        var result = new List<int>();

        foreach (var part in parts)
        {
            if (int.TryParse(part, out int number) == false)
            {
                throw new FormatException($"Invalid number format: '{part}'.");
            }

            if (number < 1 || number > 5)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"Number must be between 1 and 5. Got: {number}");
            }

            result.Add(number);
        }

        return result.ToArray();
    }
}