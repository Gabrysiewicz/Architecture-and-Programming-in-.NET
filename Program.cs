using Laboratorium1;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        static void fizzbuzz()
        {
            int length = 100;
            for (int i = 1; i <= length; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void guess()
        {
            var rand = new Random();
            int min = 1;
            int max = 100;
            var value = rand.Next(min, max);
            bool won = false;
            Console.WriteLine($"Guess the number from range {min} : {max}");
            while (!won)
            {
                Console.Write(": ");
                int userGuess;
                bool parsed = Int32.TryParse(Console.ReadLine(), out userGuess);
                if (parsed)
                {
                    if (userGuess == value)
                    {
                        won = true;
                    }
                    if (userGuess > value)
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (userGuess < value)
                    {
                        Console.WriteLine("Too low");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }

            }
            Console.WriteLine($"You Won! The number was {value}");

        }
        static void guessCount()
        {
            var rand = new Random();
            int min = 1;
            int max = 100;
            var value = rand.Next(min, max);
            bool won = false;
            int trials = 0;
            string hint = "";
            while (!won)
            {
                Console.Clear();
                Console.WriteLine($"Guess the number from range {min} : {max} \n trials: {trials} \n Hint:{hint}");
                Console.Write(": ");
                int userGuess;
                bool parsed = Int32.TryParse(Console.ReadLine(), out userGuess);
                if (parsed)
                {
                    if (userGuess == value)
                    {
                        won = true;
                    }
                    if (userGuess > value)
                    {
                        hint = "Too High";
                    }
                    else if (userGuess < value)
                    {
                        hint = "Too Low";
                    }
                }
                else
                {
                    hint = "Incorrect input";
                }
                trials++;

            }
            Console.WriteLine($"You Won! The number was {value}. You did it in {trials}th trial");

        }

        static void guessHS()
        {
            var rand = new Random();
            int min = 1;
            int max = 100;
            var value = rand.Next(min, max);
            bool won = false;
            int trials = 0;
            string hint = "";
            Console.Write("Whats your name: ");
            var name = Console.ReadLine();
            var highScore = new HighScore
            {
                Name = name,
                Trials = 0
            };
            while (!won)
            {
                Console.Clear();
                Console.WriteLine($"Guess the number from range {min} : {max} \n trials: {trials} \n Hint:{hint}");
                Console.Write(": ");
                int userGuess;
                bool parsed = Int32.TryParse(Console.ReadLine(), out userGuess);
                if (parsed)
                {
                    if (userGuess == value)
                    {
                        won = true;
                    }
                    if (userGuess > value)
                    {
                        hint = "Too High";
                    }
                    else if (userGuess < value)
                    {
                        hint = "Too Low";
                    }
                }
                else
                {
                    hint = "Incorrect input";
                }
                trials++;

            }
            Console.WriteLine($"You Won! The number was {value}. You did it in {trials}th trial");
            highScore.Trials = trials;

            // Init
            List<HighScore> highScores;
            const string FileName = "highscores.json";
            if (File.Exists(FileName))
                highScores =
                JsonSerializer.Deserialize<List<HighScore>>(File.ReadAllText(FileName));
            else
                highScores = new List<HighScore>();
            // Update
            highScores.Add(highScore);
            File.WriteAllText(FileName, JsonSerializer.Serialize(highScores));

            // Show
            Console.WriteLine("=== Scoreboard ===");
            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.Name} -- {item.Trials} trials");
            }
        }
        fizzbuzz();
        //guess();
        //guessCount();
        //guessHS();
    }
}