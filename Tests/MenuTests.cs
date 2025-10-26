using PockerDice;

namespace Tests;

// [TestFixture]
public class MenuTests
{
    // [Test]
    public void Options_ShouldPrintCorrectMenu_WhenIsFirstStepIsTrue()
    {
        var menu = new Menu(true);
        var sw = new StringWriter();
        Console.SetOut(sw);

        menu.Options();

        var output = sw.ToString();
        StringAssert.Contains("Select menu option", output);
        StringAssert.Contains("1 - Roll all your dice", output);
        StringAssert.DoesNotContain("2 - Select dice to roll", output);
        StringAssert.Contains("0 - Exit", output);
    }

    // [Test]
    public void Options_ShouldPrintSecondOption_WhenIsFirstStepIsFalse()
    {
        var menu = new Menu(false);
        var sw = new StringWriter();
        Console.SetOut(sw);

        menu.Options();

        var output = sw.ToString();
        StringAssert.Contains("Select menu option", output);
        StringAssert.Contains("1 - Roll all your dice", output);
        StringAssert.Contains("2 - Select dice to roll", output);
        StringAssert.Contains("0 - Exit", output);
    }
}