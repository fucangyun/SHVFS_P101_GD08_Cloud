class hw04
{
    public static void Age()
    {
        int num, sum = 0, i;
        float ave;
        Console.WriteLine("Please input the number of people:");
        num = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i < num;)
        {
            Console.WriteLine($"Please input age {++i}");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        ave = (float)sum / (float)num;
        Console.WriteLine($"sum of age is {sum}");
        Console.WriteLine($"average age is {ave}");
    }
    public static void Guess()
    {
        Random rand = new Random();
        int un = rand.Next(1000), tt = 0;//不包含0和1000
        Console.WriteLine("Now I have a number between 0 and 1000, please guess");
        while (tt != un)
        {
            tt = Convert.ToInt32(Console.ReadLine());
            if (tt > un) Console.WriteLine("too big, guess again");
            else if (tt < un) Console.WriteLine("too small, guess again");
        }
        Console.WriteLine("Exactly! Congratulations!");
    }
    public static void Main()
    {
        while (true)
        {
            int t;
            Console.WriteLine("welcome,\n" +
                              "enter 1 to calculate age\n" +
                              "      2 to guess number\n" +
                              "      3 to quit");
            t = Convert.ToInt32(Console.ReadLine());
            if (t == 3) break;
            else if (t == 2) Guess();
            else if (t == 1) Age();
            else
            {
                Console.WriteLine("invalid number, please input again");
                continue;
            }
        }
        Console.WriteLine("Now you have quit the game, see you~");
        Console.ReadLine();
    }
}