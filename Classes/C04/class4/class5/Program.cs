using System.Collections.Specialized;
using System.Net.Sockets;
using System.Security.AccessControl;

namespace C5//not necessary
{
    public class Program
    {
        public static void Main()
        {

            //logical operators 逻辑运算符
            // or  '|' 或
            // and '&' 与
            //relational operators 关系运算符
            //arithmetic operators 算数运算符
            //int, integer, counting numbers, whole numbers

            /*int ArithmeticOperatorPlusPlus = 10;//ctrl+R, ctrl+R
            ArithmeticOperatorPlusPlus ++;
            Console.WriteLine(ArithmeticOperatorPlusPlus);//another way of printing*/

            /*int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i}");//wrtieline会自动回车
            }*/

            /*string input = "";
            while(true)
            {
                Console.WriteLine("In while....");
                input = Console.ReadLine();
                if(input == "Q") break;
            }*/

            //do-while at least run 1 time
            /*int i;
            Console.WriteLine("Enter 1 for options\n" +
                              "      2 to quit\n" +
                              "      3 to start");
            do
            {
                i = Convert.ToInt32(Console.ReadLine());
            } while (i < 1 || i > 3);*/

            /*int num=1;
            Console.WriteLine(num);
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);*/
            //Convert.ToInt32()函数的输入貌似只能是数字（形式的字符串）

            /*int i, j;
            for(i=0;i<5;i++)
            {
                for (j = 0; j < 3; j++)
                    Console.WriteLine($"i is {i}, j is {j}");
            }*/



            //var scores = new int[5];
            /*int[] scores;
            int[] marks = new int[5] { 99, 98, 92, 97, 95 };
            int i;
            scores = marks;
            Console.WriteLine(scores[3]);
            marks[3] = 7;
            Console.WriteLine(scores[3]);
            Console.WriteLine($"the length of scores is {scores.Length}");
            for (i=0;i<scores.Length;i++)
            {
                Console.WriteLine(scores[i]);
            }*/

            //年龄计算器：欢迎user，输入一个数字，表示人物的数量；为每个人输入年龄；计算总和、平均值。
            //猜数游戏：类似“给出一个1~10000内的数字”，给出过大或过小的提示，直到猜出
            //主界面给出三个选项：第一个询问，你要玩年龄计算器吗；第二个，猜猜数游戏；第三个，退出

            Console.ReadLine();
            return;

        }
    }
}