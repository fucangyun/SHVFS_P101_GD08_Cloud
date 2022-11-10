struct student
{
    public int id;
    public int age;
    public string name;
    public string description;
}
class C05
{
    int j;
    //https://www.cnblogs.com/sunliyuan/p/5999045.html
    //形参只进不出，ref有进有出，out只出不进
    //这意味着在构造函数内一开始的out变量是可以看做一个崭新声明的变量，故不可进行调用，且在函数结束前必须赋值
    public static void test(int aa, ref int bb, out int cc)
    {
        aa = 3;
        bb = 3;
        cc = 3;
    }

    public static void Main()
    {
        string input = "";
        int i;
        int[] a =new int[5] {1,1,1,1,1};

        #region note1
        //圆括号 parentheses 
        //大括号 curly brace
        //分号   semicolon
        //函数   function


        /*test(a[0],ref a[1],out a[2]);
        Console.WriteLine($"{a[0]} {a[1]} {a[2]}");*/

        /*while (true)
        {          
            input = Console.ReadLine();
            bool aaa = int.TryParse(input, out i);
            Console.WriteLine(i);
        }*/
        //int.Tryparse会动识别input字符串是否可转化为整型
        //如果成功，式子本身为真，i成为数字；如果失败，式子本身为假，i=0

        #endregion

        //student Cloud =new student();//这样似乎是指针
        student Cloud;                 //这样似乎安全一点
        Cloud.age = 2;
        Cloud.name = "zcw";
        Cloud.description = "don't like study but p5r";
        student Johnny;
        Johnny.description = Cloud.description;
        Cloud.description = "like study";
        Console.WriteLine(Cloud.description);
        Console.WriteLine(Johnny.description);


        Console.WriteLine("Nothing ever ends.");
        Console.ReadLine();
    }
}