// 1. Generate a Random Number
Random random = new Random();
int secretNumber = random.Next(1, 101); // Generates a number between 1 and 1

bool guessedCorrectly = false;
while (!guessedCorrectly)
{
    Console.Write("Guess a number between 1 and 100: ");
    string input = Console.ReadLine();
    int guess;
    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    // Handle invalid input (ask again or end the game)
    }
    else
    {
        // 3. Check the Guess (within the loop
        if (guess < secretNumber)
        {
           Console.WriteLine("Too low!");
        }
          else if (guess > secretNumber)
        {
           Console.WriteLine("Too high!");
        }
         else
        {
        Console.WriteLine("You guessed it! Congratulations!");
        }
    }
    if(guess == secretNumber)
    {
        guessedCorrectly = true;
    }
}