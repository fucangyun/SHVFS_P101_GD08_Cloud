class Quiz06
{
    public static void Main()
    {
        string secret, guess, name;
        int i,j;
        Console.WriteLine("Welcome! Please input your name!");
        name = Console.ReadLine();
        Random random = new Random();
        j = random.Next(3);


        string[] a = {"cloud", "Cloud", "CLOUD"};
        Console.WriteLine($"Hi {name}, let's guess! Now all the words are {a[0]}, {a[1]} and {a[2]} !");
        for (i=1; ;i++)
        {
            guess = Console.ReadLine();
            if (guess == a[j]) break;
            Console.WriteLine("Wrong! Guess again!");
        }


        /*int secretnum = random.Next(97, 123);
        secret = Convert.ToChar(secretnum).ToString();
        Console.WriteLine($"Hi {name}, let's guess! input your guess! Tips: Single lowercase letter!");
        for (i=1; ;i++)
        {
            guess = Console.ReadLine();
            Console.Clear();
            if (string.Compare(guess,secret)==0) break;
            else if (string.Compare(guess, secret) == 1)
            Console.WriteLine($"It's too big! Guess again!");
            else if (string.Compare(guess, secret) == -1)
            Console.WriteLine($"It's too small! Guess again!");
        }*/

        if(i==1) Console.WriteLine($"Hi {name}! You won after {i} time!");
        else     Console.WriteLine($"Hi {name}! You won after {i} times!");
    }
}