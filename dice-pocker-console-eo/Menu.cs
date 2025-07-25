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
        }
        
        Console.WriteLine("0 - Exit");
    }
}