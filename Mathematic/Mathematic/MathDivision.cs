using Mathematic.Models;
using System;

using System.Diagnostics;
using System.Linq;

namespace Mathematic
{
    internal class MathDivision
    {
        internal static int[] GetDivisionNumber()
        {
            var random = new Random();

            int firstNumber = random.Next(1 , 100);
            int secondNumber = random.Next(1 , 100);

            while(firstNumber % secondNumber !=0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);
            }
            var result = new int[5];
            result [0] = firstNumber;
            result [1] = secondNumber;
            return result;
        }
        internal static void Division(string v)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int score = 0;
            Console.WriteLine("Select which level of game you want to play:\n" +
                "E - Easy\n" +
                "N - Normal\n" +
                "H - Hard");
            var selectLevel = Console.ReadLine();
            switch (selectLevel.Trim().ToLower())
            {
                case "e":
                    sw.Start();
                    for (int i = 0; i < 5; i++)
                    {
                        var random = new Random();
                        Console.WriteLine($"Round {i}");
                        
                        int firstNumber = random.Next(1, 9);
                        int secondNumber = random.Next(1, 9);
                        while (firstNumber % secondNumber != 0)
                        {
                            firstNumber = random.Next(1, 9);
                            secondNumber = random.Next(1, 9);
                        }
                        var gameNumber = new int[5];
                        gameNumber [0] = firstNumber;
                        gameNumber [1] = secondNumber;

                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        var result = Console.ReadLine();
                        result = Helpers.ValidateInput (result);
                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine($"Your answer {result} is correct. Press any key for next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                        }
                        if(i == 4)
                        {
                            sw.Stop();
                            Console.WriteLine($"Game over! Your final score {score}pts and finished {sw}. Press any key to go back to main menu");
                            Console.ReadLine();
                        }
                    }
                    Helpers.AddToHistory(score, GameType.Division);
                    break;
                case "n":
                    for (int i = 0; i < 5; i++)
                    {
                        sw.Start();
                        var random = new Random();
                        Console.WriteLine($"Round {i}");
                        
                        int firstNumber = random.Next(10, 30);
                        int secondNumber = random.Next(10, 30);
                        while (firstNumber % secondNumber != 0)
                        {
                            firstNumber = random.Next(10, 30);
                            secondNumber = random.Next(10, 30);
                        }
                        var gameNumber = new int[5];
                        gameNumber[0] = firstNumber;
                        gameNumber[1] = secondNumber;

                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        var result = Console.ReadLine();
                        result = Helpers.ValidateInput(result);
                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine($"Your answer {result} is correct. Press any key for next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                        }
                        if (i == 4)
                        {
                            sw.Stop();
                            Console.WriteLine($"Game over! Your final score {score}pts and finished {sw}. Press any key to go back to main menu");
                            Console.ReadLine();
                        }
                    }
                    Helpers.AddToHistory(score, GameType.Division);
                    break;
                case "h":
                    for (int i = 0; i < 5; i++)
                    {
                        sw.Start();
                        var random = new Random();
                        Console.WriteLine($"Round {i}");
                        
                        int firstNumber = random.Next(30, 100);
                        int secondNumber = random.Next(30, 100);
                        while (firstNumber % secondNumber != 0)
                        {
                            firstNumber = random.Next(30, 100);
                            secondNumber = random.Next(30, 100);
                        }
                        var gameNumber = new int[5];
                        gameNumber[0] = firstNumber;
                        gameNumber[1] = secondNumber;

                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        var result = Console.ReadLine();
                        result = Helpers.ValidateInput(result);
                        if (int.Parse(result) == firstNumber / secondNumber)
                        {
                            Console.WriteLine($"Your answer {result} is correct. Press any key for next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                        }
                        if (i == 4)
                        {
                            sw.Stop();
                            Console.WriteLine($"Game over! Your final score {score}pts and finished in {sw}. Press any key to go back to main menu");
                            Console.ReadLine();
                        }
                    }
                    Helpers.AddToHistory(score, GameType.Division);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
