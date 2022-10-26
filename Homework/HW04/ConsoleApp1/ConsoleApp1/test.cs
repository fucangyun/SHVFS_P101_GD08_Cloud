/*class online_course
{
    public static void Main()
    {
        int player_choice = 0 , number_age, summary_age, i, temp, guess;//状态符，年龄的数量，年龄的和，循环符，临时符，系统预先设置的数字用来猜
        float average;//平均值
        while(player_choice!=3)
        {
            Console.WriteLine("Welcome! Please enter 1 to start the age calculator\n" +
                              "                enter 2 to start number guess game\n" +
                              "                enter 3 to quit the game");
            player_choice = Convert.ToInt32(Console.ReadLine());
            if (player_choice == 1)
            {
                summary_age = 0;
                Console.WriteLine("Please input the number of people:");
                number_age = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= number_age; i++)
                {
                    Console.WriteLine($"Please input the age {i}:");
                    temp = Convert.ToInt32(Console.ReadLine());
                    summary_age = summary_age + temp;
                }
                average = (float)summary_age / (float)number_age;
                Console.WriteLine($"The sum of these people's age is {summary_age}");
                Console.WriteLine($"The average of these people's age is {average}\n");
            }
            else if (player_choice == 2)
            {
                guess = 1220;//预先设置一个要猜的数字
                temp = 0;//玩家输入的数字
                Console.WriteLine("Please enter the num you guess:");
                while (temp!=guess)
                {
                    temp = Convert.ToInt32(Console.ReadLine());//读取玩家猜的数字
                    if(temp>guess)
                    {
                        Console.WriteLine("Too big, please enter again:");
                    }
                    else if (temp < guess)
                    {
                        Console.WriteLine("Too small, please enter again:");
                    }
                }
                Console.WriteLine("Congratulations! You have guessed the number!\n");
            }
            else if(player_choice!=3) Console.WriteLine("Invalid number! please enter again.\n");
        }
        Console.WriteLine("You have quit the game. See you~");
        Console.ReadLine();
    }
}*/