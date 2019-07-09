using System;

namespace _05_逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 逻辑运算符的练习   用户输入语文成绩、数学成绩，做判断处理

            Console.WriteLine("小苏，输入你的语文成绩");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("小苏，输入你的数学成绩");
            int math = Convert.ToInt32(Console.ReadLine());

            //// 1）语文、数学都大于90  逻辑与
            //bool b = chinese > 90 && math < 90;
            //Console.WriteLine(b);
            //Console.ReadKey();

            // 2）语文、数学有一门大于90 逻辑或
            bool b = chinese > 90 || math > 90;
            Console.WriteLine(b);
            Console.ReadKey();


            #endregion
        }
    }
}
