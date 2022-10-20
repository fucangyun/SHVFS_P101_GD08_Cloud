#region Stracture of a program//无实义，用来分块

using System;

namespace SHVFS_P101_GD08_Q1_Cloud
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region exercise
            /*            float myFirstFloat = 0.142857f;
                        float mySecondFloat = 12.20f;//float末尾要加f
                        var myThirdSome = 3.31;//不加f默认为double型

                        Console.WriteLine($"my first float is: {myFirstFloat}");
                        Console.WriteLine($"my second float is: {mySecondFloat}");
                        Console.ReadLine();*/



            /*int myfirstnumberchar = 'A';
            char myfirstcharnumber = (char)65;
            Console.WriteLine($"my first number char is: {myfirstnumberchar}, and my first char number is: {myfirstcharnumber}");
            Console.ReadLine();*/


            /*            string myfirststring = "hello, Chris!";
                        Console.WriteLine($"my first string is {myfirststring} has\n {myfirststring.Length} characters");
                        Console.ReadLine();*/

            /*
                        string name, age;
                        int idealAge = 21;
                        Console.Clear();
                        Console.WriteLine("Hi! What's your name?");
                        name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("And what's your age?");
                        age = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Oh, hello {name}, nice to know you're {age}, too bad you're not {idealAge}!");
                        Console.ReadLine();*/


            /*            var number1 = 3;
                        var number2 = 4;
                        int total_1;
                        float total_2;
                        total_1 = number1 + number2;
                        Console.WriteLine($"Addition: {total_1}");
                        total_1 = number1 - number2;
                        Console.WriteLine($"Subtraction: {total_1}");
                        total_1 = number1 * number2;
                        Console.WriteLine($"Multiplication: {total_1}");
                        total_1 = number1 / number2;
                        Console.WriteLine($"Division 1: {total_1}");
                        total_2 = number1 / (float)number2;
                        Console.WriteLine($"Division 2: {total_2}");
                        total_1 = number1 % number2;
                        Console.WriteLine($"Modulus: {total_1}");
                        total_1 = (number1 + number2) * 2;
                        Console.WriteLine($"Mathsss: {total_1}");
                        Console.ReadLine();*/


            /*            string number1, number2;
                        Console.WriteLine("Hi, i'm Mr.Calculator! Please enter a number! ^_^");
                        number1 = Console.ReadLine(); 
                        Console.Clear();
                        Console.WriteLine("Oh boy, that was Great!  Please enter a second number so I can calculater! \n I'm gonna add them together!");
                        number2 = Console.ReadLine();
                        Console.Clear();
                        var num1Converted = Convert.ToInt32(number1);
                        var num2Converted = Convert.ToInt32(number2);
                        Console.WriteLine($"Those were great numbers! I've added them up, and the sum is {num1Converted + num2Converted}!!!");
                        Console.ReadLine();*/

            #endregion exercise
            while (true)
            {
                float num1 = (float.Parse(Console.ReadLine()) - 32) / 1.8f;
                Console.WriteLine($"{num1}");
            }


            //Console.WriteLine((float.Parse(Console.ReadLine()) - 32) / 1.8);
            Console.ReadLine();


        }
    }
}

#endregion
/*
keyword 关键字
curly brace 大括号
access modifier 访问修饰符
semi-colon 分号
statement 声明
backslash 反斜杠
comment 注释
*/