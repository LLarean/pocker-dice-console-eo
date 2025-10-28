using PockerDice;

namespace Tests;

[TestFixture]
public class MenuTests
{
    private Menu _menu;
    private StringWriter _consoleOutput;
    private TextWriter _originalConsoleOut;

    [SetUp]
    public void Setup()
    {
        _consoleOutput = new StringWriter();
        _originalConsoleOut = Console.Out;
        Console.SetOut(_consoleOutput);
    }

    [TearDown]
    public void TearDown()
    {
        Console.SetOut(_originalConsoleOut);
        _consoleOutput.Dispose();
    }

    private void SetConsoleInput(string input)
    {
        var consoleInput = new StringReader(input);
        Console.SetIn(consoleInput);
    }
    
    [Test]
    public void Options_ShouldPrintCorrectMenu_WhenIsFirstStepIsTrue()
    {
        var menu = new Menu(true);
        var sw = new StringWriter();
        Console.SetOut(sw);

        menu.Options();

        var output = sw.ToString();
        StringAssert.Contains("Select option (1-RollAll, 3-Skip, 0-Exit): ", output);
    }

    [Test]
    public void Options_ShouldPrintSecondOption_WhenIsFirstStepIsFalse()
    {
        var menu = new Menu(false);
        var sw = new StringWriter();
        Console.SetOut(sw);

        menu.Options();

        var output = sw.ToString();
        StringAssert.Contains("Select option (1-RollAll, 2-Skip, 3-Select, 0-Exit): ", output);
    }
    
    [Test]
    public void OptionsNumber_ValidInput0_ReturnsRollAllDice()
    {
        _menu = new Menu(true);
        SetConsoleInput("0");

        var result = _menu.OptionsNumber();

        Assert.That(result, Is.EqualTo(MenuOption.RollAllDice));
    }
    
    [Test]
    public void OptionsNumber_ValidInput1_ReturnsSelectDice()
    {
        _menu = new Menu(true);
        SetConsoleInput("1");

        var result = _menu.OptionsNumber();

        Assert.That(result, Is.EqualTo(MenuOption.SelectDice));
    }

    [Test]
    public void OptionsNumber_ValidInput2_ReturnsSkipTurn()
    {
        _menu = new Menu(true);
        SetConsoleInput("2");

        var result = _menu.OptionsNumber();

        Assert.That(result, Is.EqualTo(MenuOption.SkipTurn));
    }

    [Test]
    public void OptionsNumber_ValidInput3_ReturnsExitGame()
    {
        _menu = new Menu(true);
        SetConsoleInput("3");

        var result = _menu.OptionsNumber();

        Assert.That(result, Is.EqualTo(MenuOption.ExitGame));
    }
    
    [Test]
    public void OptionsNumber_InvalidNumberFormat_ReturnsExitGameAndPrintsError()
    {
        _menu = new Menu(true);
        SetConsoleInput("abc");
    
        var result = _menu.OptionsNumber();
        var output = _consoleOutput.ToString();

        Assert.That(result, Is.EqualTo(MenuOption.ExitGame));
        Assert.That(output, Contains.Substring("Error"));
        Assert.That(output, Contains.Substring("Please enter a number"));
    }

    [Test]
    public void OptionsNumber_OutOfRangeNumber_ReturnsExitGameAndPrintsError()
    {
        _menu = new Menu(true);
        SetConsoleInput("5");
    
        var result = _menu.OptionsNumber();
        var output = _consoleOutput.ToString();

        Assert.That(result, Is.EqualTo(MenuOption.ExitGame));
        Assert.That(output, Contains.Substring("Error"));
        Assert.That(output, Contains.Substring("Invalid option"));
    }

    [Test]
    public void OptionsNumber_NegativeNumber_ReturnsExitGameAndPrintsError()
    {
        _menu = new Menu(true);
        SetConsoleInput("-1");
    
        var result = _menu.OptionsNumber();
        var output = _consoleOutput.ToString();

        Assert.That(result, Is.EqualTo(MenuOption.ExitGame));
        Assert.That(output, Contains.Substring("Error"));
        Assert.That(output, Contains.Substring("Invalid option"));
    }
    
    [Test]
    public void OptionsNumber_EmptyInput_ReturnsExitGameAndPrintsError()
    {
        _menu = new Menu(true);
        SetConsoleInput("");
    
        var result = _menu.OptionsNumber();
        var output = _consoleOutput.ToString();

        Assert.That(result, Is.EqualTo(MenuOption.ExitGame));
        Assert.That(output, Contains.Substring("Error"));
    }

    [Test]
    public void OptionsNumber_WhitespaceInput_ReturnsExitGameAndPrintsError()
    {
        _menu = new Menu(true);
        SetConsoleInput("   ");
    
        var result = _menu.OptionsNumber();
        var output = _consoleOutput.ToString();

        Assert.That(result, Is.EqualTo(MenuOption.ExitGame));
        Assert.That(output, Contains.Substring("Error"));
    }
}