using System;

namespace _09_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  比较3个数字的大，不考虑相等 方法一

            //// 分别提示并接收用户输入的3个数字
            //Console.WriteLine("请输入第一个数字");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("最大的数字为");
            //// 三种情况应该使用if-else-if来做

            //// 第一个数大于第二个数，大于第三个数
            //if (numberOne > numberTwo && numberOne > numberThree)
            //{
            //    Console.WriteLine(numberOne);
            //}
            //// 第二个数大于第一个数，大于第三个数
            //else if (numberTwo > numberOne && numberTwo > numberThree)
            //{
            //    Console.WriteLine(numberTwo);
            //}

            //// 第一个数，第二个数都不是最大数，那就只能第三个数最大
            //else
            //{
            //    Console.WriteLine(numberThree);
            //}

            //Console.ReadKey();

            #endregion

            #region 比较3个数字的大，不考虑相等 方法二

            ////分别提示并接收用户输入的3个数字
            //Console.WriteLine("请输入第一个数字");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int numberThree = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("最大的数字为");

            //// 先让第一个跟第二个比，若大于怎跟第三个比，若大于则第一个，否则第三个
            //if (numberOne > numberTwo)
            //{
            //    if (numberOne > numberThree)   // 第一个大于第二个，判断第一个是否大于第三个
            //    {
            //        Console.WriteLine(numberOne);
            //    }
            //    else   // 第三个大于第一个，第一个大于第二个，所以第三个最大
            //    {
            //        Console.WriteLine(numberThree);
            //    }
            //}
            //else
            //{
            //    if (numberTwo > numberThree)   // 第二个大于第一个，判断第二个是否大于第三个
            //    {
            //        Console.WriteLine(numberTwo);
            //    }
            //    else          // 第三个大于第二个，第二个又大于第一个，所以第三个最大
            //    { 
            //        Console.WriteLine(numberThree);
            //    }
            //}

            //Console.ReadKey();

            #endregion

            #region 提示用户输入账号密码，若都正确，则登录成功，否则重新输入一次判断，若正确则登录成功否则登录失败，结束

            //Console.WriteLine("请输入用户名");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入用户密码");
            //string password = Console.ReadLine();

            //if (userName == "admin" && password == "password")
            //{
            //    Console.WriteLine("恭喜您，登录成功");
            //}
            //else
            //{
            //    Console.WriteLine("用户名或密码不正确，请按任意键重新输入");
            //    Console.ReadKey();
            //    Console.WriteLine("请重新输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请重新输入用户密码");
            //    password = Console.ReadLine();
            //    if (userName == "admin" && password == "password")
            //    {
            //        Console.WriteLine("恭喜您，登录成功，您一共输入了两次用户名和密码");
            //    }
            //    else
            //    {
            //        Console.WriteLine("很抱歉，两次输入的用户名和密码都不正确，登录失败");
            //    }

            //}

            #endregion
        }
    }
}
