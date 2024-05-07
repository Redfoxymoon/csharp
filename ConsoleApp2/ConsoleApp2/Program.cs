namespace ConsoleApp2;

class Program
{
    public static void Main(string[] args)
    {
        var random = new Random();
        var secret = random.Next(1,100);
        int guessesUsed = 0, guess;
        Console.WriteLine("Guess the number between 1 and 100.");
        while (true)
        {
            string guessStr = Console.ReadLine();
            if (string.IsNullOrEmpty(guessStr) || string.IsNullOrWhiteSpace(guessStr))
                continue;
            try
            {
                guess = int.Parse(guessStr);
            }
            catch (Exception e)
            {
                Console.WriteLine("Not a number...");
                continue;
            }
            if (guess > secret)
            {
                Console.WriteLine("Guess is greater than the secret.");
                guessesUsed++;
            }
            else if (guess < secret)
            {
                Console.WriteLine("Guess is lesser than the secret.");
                guessesUsed++;
            }
            else
            {
                Console.WriteLine("Congratulations, you won.");
                Console.WriteLine($"You guessed {guessesUsed} times.");
                break;
            }
        }
    }
}