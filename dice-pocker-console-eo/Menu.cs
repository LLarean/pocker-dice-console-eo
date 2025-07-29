namespace PockerDice;

public class Menu(bool isFirstStep)
{
    public void Options()
    {
        Console.Write(isFirstStep == false
            ? "Select option (1-RollAll, 3-Skip, 0-Exit): "
            : "Select option (1-RollAll, 2-Skip, 3-Select, 0-Exit): ");
    }

    public MenuOption OptionsNumber()
    {
        try
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                throw new FormatException($"Invalid input: '{input}'. Please enter a number.");
            }

            return choice switch
            {
                0 => MenuOption.RollAllDice,
                1 => MenuOption.SelectDice,
                2 => MenuOption.SkipTurn,
                3 => MenuOption.ExitGame,
                _ => throw new ArgumentOutOfRangeException(nameof(choice), 
                    $"Invalid option: {choice}. Must be 0-3.")
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}. Please try again.");
        }

        return MenuOption.ExitGame;
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