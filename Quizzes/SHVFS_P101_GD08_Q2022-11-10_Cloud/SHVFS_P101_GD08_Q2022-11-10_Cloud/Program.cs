class Quiz06
{
    public static void Main()
    {
        string secret, guess, name;
        int i;
        Random random = new Random();
        int secretnum = random.Next(97, 123);
        secret = Convert.ToChar(secretnum).ToString();
        Console.WriteLine("Welcome! Please input your name!");
        name= Console.ReadLine();
        Console.WriteLine($"Hi {name}, let's guess! input your guess!");
        for (i=1; ;i++)
        {
            guess = Console.ReadLine();
            Console.Clear();
            if (guess == secret) break;
            /*            else if (Convert.ToChar(guess).ToInt32() > secretnum)
                            Console.WriteLine($"It's too big! Guess again!");
                        else if (Convert.ToInt32(guess) < secretnum)
                            Console.WriteLine($"It's too big! Guess again!");*/
            Console.WriteLine($"Wrong! Please guess again!");
        }
        Console.WriteLine($"Hi {name}! You won after {i} times!");
    }
}