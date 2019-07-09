using System;

namespace _06_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 闰年的判断

            //Console.WriteLine("请输入要判断的年份");
            //int year = Convert.ToInt32(Console.ReadLine());

            //// 条件：年份能被400整除或者能被4整除不能被100整除
            //bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

            //Console.WriteLine(b);
            //Console.ReadKey();

            #endregion

            #region   单个&和|的使用情况   （不管什么情况，两边都会比较）

            bool b = 5 < 3 && 5 > 3;
            Console.WriteLine(b);
            Console.ReadKey();

            #endregion
        }
    }
}
