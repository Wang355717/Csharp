namespace ConsoleApp1
{
    internal class Program
    {
        // 类
        class Person
        {
            // 数据默认private私有的
            public int _age;
            public string _name;
            // 加上static修饰的属于静态成员
            public static int s_maxAge = 150;
        }
        static void Main(string[] args)
        {
            // 控制台打印输出（换行）
            Console.WriteLine("Hello World");
            // 控制台打印输出（不换行）
            Console.Write("Hello World");


            //变量和类型
            // 整形（正整数或者负整数）
            int age = 20;
            // 默认小数类型是double
            double pi = 3.14159;
            // 如果需要声明类型为float，需要在数字后面加上f或者F
            float distance = 23.124f;
            // decimal类型需要在数字后面加上m或者M
            decimal price = 19.99m;
            // 布尔类型值是：true或false
            bool isSunn = false;
            // 字符类型只能存储一个字符，必须用单引号括起来
            char grade = 'A';
            // 字符串类型
            string greeting = "hello word";
            Console.WriteLine(age);
            Console.WriteLine(pi);
            Console.WriteLine(distance);
            Console.WriteLine(price);
            Console.WriteLine(isSunn);
            Console.WriteLine(greeting);
            Console.WriteLine(greeting);

            int a = 1;
            int b = 2;
            int result = a + b;
            //格式化输出
            Console.WriteLine($"{a} + {b} = {result}");

            // var声明的变量会自动的根据值的类型来判断变量的类型
            var i = 0;
            // var 的用途
            List<Dictionary<string, int>> list1 = new List<Dictionary<string, int>>();
            // 上边的代码就可以简化成
            var list2 = new List<Dictionary<string, int>>();


            // 类型转换
            // 类
            var p1 = new Person();
            p1._age = 18;
            p1._name = "Tom";
            Console.WriteLine($"{p1._name} is {p1._age} year");
            // 调用类的静态资源格式为：类名.静态成员名
            Console.WriteLine($"人最多可以活{Person.s_maxAge}岁");


            // 调用无返回值的方法(类名可以省略)
            Greet();
            // 调用有返回值的方法，并接收返回值
            int result2 = Add(3, 5);
            Console.WriteLine(result2);
        }

        // 无返回值的方法，使用void修饰
        // 如果方法只有一条语句，可以使用表达式体方法（=>）来简化方法的定义
        static void Greet() => Console.WriteLine("我在学习C#");
        // 有返回值的方法，使用返回值类型修饰
        static int Add(int x, int y) => x + y;
    }
}
