using Mathematic;

var random = new Random();
int Number1;
int Number2;
DateTime dateTime = DateTime.Now;

AdditionGame additionGame = new AdditionGame();
Console.WriteLine("Please enter your name\n");
var name = Console.ReadLine();
while(string.IsNullOrEmpty(name))
{
    Console.WriteLine("Must enter your name");
    name = Console.ReadLine();
}
Console.Clear();
Console.WriteLine($"Welcome {name}. It's {dateTime}");
var gameOn = true;
do
{
    Console.Clear();
    Console.WriteLine("Which game do you want to play:\n" +
        "V - Game History\n" +
        "A - Addition\n" +
        "S - Subtraction\n" +
        "M - Multiplication\n" +
        "D - Division\n" +
        "R - Random Game\n" +
        "Q - Quite game");
    string menuOption = Console.ReadLine();
    switch (menuOption.Trim().ToLower())
    {
        case "v":
            Helpers.PrintGames();
            break;
        case "a":
            additionGame.Addition("Addition Game selected");
            break;
        case "s":
            MathSubtraction.Subtraction("Subtraction Game selected");
            break;
        case "m":
            MathMultiplication.Multiplication("Multiplication Game selected");
            break;
        case "d":
            MathDivision.Division("Division Game selected");
            break;
        case "r":
            RandomOperation.OperationString("Random Game selected");
            break;
        case "q":
            Environment.Exit(0);
            Console.WriteLine("Exit game");
            break;
        default:
            Console.WriteLine($"Good bye {name} come back soon");
            break;
    }
}while(gameOn);