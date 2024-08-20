using Mathematic.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematic
{
    internal class RandomOperation
    {
        internal static void OperationString(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var random = new Random();
            int score = 0;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 5; i++)
            {
                sw.Start();
                int firstNumber = random.Next(1, 20);
                int secondNumber = random.Next(1, 20);
                

                var gameOperation = random.Next(1, 4);
                switch (gameOperation)
                {
                    case 1:
                        Console.WriteLine($"{firstNumber} + {secondNumber}");
                        var result = Console.ReadLine();
                        result = Helpers.ValidateInput(result);
                        if(int.Parse(result) == firstNumber +  secondNumber)
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
                        break;
                    case 2:
                        Console.WriteLine($"{firstNumber} - {secondNumber}");
                        var answer = Console.ReadLine(); 
                        answer = Helpers.ValidateInput(answer);
                        if (int.Parse(answer) == firstNumber - secondNumber)
                        {
                            Console.WriteLine($"Your answer {answer} is correct. Press any key for next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine($"{firstNumber} * {secondNumber}");
                        var ans = Console.ReadLine();
                        ans = Helpers.ValidateInput(ans);
                        if(int.Parse(ans) == firstNumber * secondNumber)
                        {
                            Console.WriteLine($"Your answer {ans} is correct. Press any key for next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        var gameNumber = MathDivision.GetDivisionNumber();
                        firstNumber = gameNumber[0];
                        secondNumber = gameNumber[1];

                        Console.WriteLine($"{firstNumber} / {secondNumber}");
                        var res = Console.ReadLine();
                        res = Helpers.ValidateInput(res);
                        if(int.Parse(res) == firstNumber / secondNumber)
                        {
                            Console.WriteLine($"Your answer {res} is correct. Press any key for next question");
                            score++;
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Your answer is not correct. Press any key for next question");
                            Console.ReadLine();
                        }
                        break;

                }
                if(i ==4)
                {
                    sw.Stop();
                    Console.WriteLine($"Game over! Your final score {score}pts and finished the game {sw}. Press any key to go back to main menu");
                    Console.ReadLine();

                }
            }
            Helpers.AddToHistory(score, GameType.RandomOperation);
        }
    }
}
