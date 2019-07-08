using System;

namespace _03_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 非兼容类型转换学习

            // 强制类型转换    自动类型转换   条件:类型兼容
            // int --> double  double --> int
            // 类型不兼容转换
            //Console.WriteLine(Convert.ToDouble("123.12"));
            //Console.WriteLine(Convert.ToInt32("14"));
            //Console.ReadKey();

            #endregion

            #region 用户输入姓名 语文 数学 英语 计算总成绩和平均成绩

            //Console.WriteLine("请输入你的姓名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入你的语文成绩");
            //string strChinese = Console.ReadLine();
            //Console.WriteLine("请输入你的数学成绩");
            //string strMath = Console.ReadLine();
            //Console.WriteLine("请输入你的英语成绩");
            //string strEnglish = Console.ReadLine();

            //// 字符串相加,最终会相连接  若需参与计算则需转换为int或double
            ////int chinese = Convert.ToInt32(strChinese);
            ////int math = Convert.ToInt32(strMath);
            ////int english = Convert.ToInt32(strEnglish);
            ////Console.WriteLine("{0}同学,你的总成绩是{1}分,平均成绩是{2:0.0}分",name,chinese+math+english, (chinese+math+english)/3.0);
            ////Console.ReadKey();

            //double chinese = Convert.ToDouble(strChinese);
            //double math = Convert.ToDouble(strMath);
            //double english = Convert.ToDouble(strEnglish);
            //Console.WriteLine("{0}同学,你的总成绩是{1}分,平均成绩是{2:0.0}分", name, chinese + math + english, (chinese + math + english) / 3);
            //Console.ReadKey();

            #endregion

            #region Convert类型转换2  计算用户输入数字的两倍

            Console.WriteLine("请输入一个数字");
            Console.WriteLine(Convert.ToDouble(Console.ReadLine()) * 2);
            Console.ReadKey();

            #endregion
        }
    }
}
