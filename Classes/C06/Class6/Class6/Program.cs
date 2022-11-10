class C06//重载，继承，访问，重写
{
    //argument 参数
    //signature 'it returns int(return), and it takes a string(argument)'
    //access modifier 访问修饰符
    //public 公有访问。不受任何限制。
    //private 私有访问。只限于本类成员访问，子类，实例都不能访问。
    //protected 保护访问。只限于本类和子类访问，实例不能访问。
    //internal 内部访问。只限于本项目(程序集)内访问，其他不能访问。
    //protected internal 内部保护访问。只限于本项目或是子类访问，其他不能访问
    //class默认都是私有

    public class Student
    {
        public int age;
        public string name;
        public Student() { }
        public Student(int AGE)
        {
            age = AGE;
        }
        public Student(int AGE, string NAME)
        {
            age = AGE;
            name = NAME;
        }
        public virtual void Ready()//要重写(override)就必须加virtual
        {
            Console.WriteLine("i'm ready.");
        }
    }

    public class Cloud : Student//inheritance 继承
    {
        public Cloud(int ag, string nam) : base(ag, nam) { }//前后对应就可以

        public override void Ready()//override 重写
        {
            base.Ready();
            Console.WriteLine("i'm ready again.");
        }
    }



    public static void Main()
    {
        //constructor 构造函数
        /*string test = "Test";
        PrintAThing(test);
        PrintAThing(1220);*/

        Student s1=new Student();
        s1.age = 11;
        Student s2 = new Student(12);
        Student s3 = new Student()
        {
            age = 13
        };
        //Console.WriteLine($"s1:{s1.age} | s2:{s2.age} | s3:{s3.age}");
        Cloud cc = new Cloud(22,"ccc");
        Console.WriteLine(cc.name);
        cc.Ready();
        Console.ReadLine();
    }

    public static void PrintAThing(string StringThing)//overload 重载
    {
        Console.WriteLine(StringThing); 
    }
    public static void PrintAThing(int IntThing)
    {
        Console.WriteLine(IntThing);
    }
}