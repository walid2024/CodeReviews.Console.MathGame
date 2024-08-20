
using Mathematic.Models;
using System.Diagnostics;


namespace Mathematic
{
    internal class AdditionGame
    {
        internal void Addition(string message)
        {
            Console.Clear();
            Stopwatch sw = new Stopwatch();
            Console.WriteLine(message);
            Console.WriteLine("Select which level of game you want to play:\n" +
                "E - Easy\n" +
                "N - Normal\n" +
                "H - Hard");
            var selectLevel = Console.ReadLine();
            var random = new Random();
            int firstNumber;
            int secondNumber;
            var score = 0;

            switch (selectLevel.Trim().ToLower())
            {
                case "e":
                    for (int i = 0; i < 5; i++)
                    {
                        sw.Start();
                        firstNumber = random.Next(1, 9);
                        secondNumber = random.Next(1, 9);

                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        var result = Console.ReadLine();
                        result = Helpers.ValidateInput(result);

                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine($"Your answer {result} is correct. Press any key for next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                            Console.ReadLine();
                        }
                        if (i == 4)
                        {
                            sw.Stop();
                            Console.WriteLine($"Game over! Your final score {score}pts and finished {sw}. Come back soon. Press any key to go back to main menu");
                            Console.ReadLine();
                        }
                    }
                    Helpers.AddToHistory(score, GameType.Addition);
                    break;
                case "n":
                    for (int i = 0; i < 5; i++)
                    {
                        sw.Start();
                        firstNumber = random.Next(10, 30);
                        secondNumber = random.Next(10, 30);
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        var result = Console.ReadLine();
                        result = Helpers.ValidateInput(result);
                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine($"Your answer {result} is correct. Press any key for next question");
                            score++; Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                            Console.ReadLine();
                        }
                        if (i == 4)
                        {
                            sw.Stop();
                            Console.WriteLine($"Game over! Your final score {score}pts and finished in {sw}. Come back soon. Press any key to go back to main menu");
                            Console.ReadLine();
                        }
                    }
                    Helpers.AddToHistory(score, GameType.Addition);
                    break;
                case "h":
                    for (int i = 0; i < 5; i++)
                    {
                        sw.Start();
                        firstNumber = random.Next(30, 100);
                        secondNumber = random.Next(30, 100);
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        var result = Console.ReadLine();
                        result = Helpers.ValidateInput(result);
                        if (int.Parse(result) == firstNumber + secondNumber)
                        {
                            Console.WriteLine($"Your answer {result} is correct. Press any key for next question");
                            score++; Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                            Console.ReadLine();
                        }
                        if (i == 4)
                        {
                            sw.Stop();
                            Console.WriteLine($"Game over!. Your final score {score}pts and finished in {sw}. Come back soon. Press any key to go back to main menu");
                            Console.ReadLine();
                        }
                    }
                    Helpers.AddToHistory(score, GameType.Addition);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
