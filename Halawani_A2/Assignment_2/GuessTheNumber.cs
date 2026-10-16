namespace Assignment_2;

/// <summary>
/// A number guessing game with difficulty levels.
/// </summary>
public class GuessTheNumber
{
    private int maxNumber;
    private int maxAttempts;
    private int secretNumber;

    /// <summary>
    /// Runs one game round.
    /// </summary>
    public void Run()
    {
        ChooseDifficulty();

        Random random = new Random();
        secretNumber = random.Next(1, maxNumber + 1);

        Console.WriteLine($"Guess a number between 1 and {maxNumber}. You have {maxAttempts} attempts.");

        int attempt = 1;
        bool won = false;

        while (attempt <= maxAttempts && won == false)
        {
            int guess = ReadGuess(attempt);

            if (guess == secretNumber)
            {
                Console.WriteLine($"Correct! You used {attempt} attempts.");
                won = true;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low.");
            }
            else
            {
                Console.WriteLine("Too high.");
            }

            attempt++;
        }

        if (won == false)
        {
            Console.WriteLine($"You are out of attempts. The number was {secretNumber}.");
        }
    }

    /// <summary>
    /// Lets the player choose Easy, Medium or Hard.
    /// </summary>
    private void ChooseDifficulty()
    {
        Console.WriteLine("Choose difficulty:");
        Console.WriteLine("1. Easy (1-10, 5 attempts)");
        Console.WriteLine("2. Medium (1-50, 7 attempts)");
        Console.WriteLine("3. Hard (1-100, 7 attempts)");

        int choice;
        bool ok = int.TryParse(Console.ReadLine(), out choice);

        while (ok == false || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid choice. Enter 1, 2 or 3: ");
            ok = int.TryParse(Console.ReadLine(), out choice);
        }

        switch (choice)
        {
            case 1:
                maxNumber = 10;
                maxAttempts = 5;
                break;
            case 2:
                maxNumber = 50;
                maxAttempts = 7;
                break;
            case 3:
                maxNumber = 100;
                maxAttempts = 7;
                break;
        }
    }

    /// <summary>
    /// Reads a guess within the allowed range.
    /// </summary>
    private int ReadGuess(int attempt)
    {
        int guess;
        Console.WriteLine($"Attempt {attempt}, enter your guess: ");
        bool ok = int.TryParse(Console.ReadLine(), out guess);

        while (ok == false || guess < 1 || guess > maxNumber)
        {
            Console.WriteLine($"Invalid guess. Enter a number between 1 and {maxNumber}: ");
            ok = int.TryParse(Console.ReadLine(), out guess);
        }

        return guess;
    }
}