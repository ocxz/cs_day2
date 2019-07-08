using System;

namespace _04_加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 自增自减的学习使用
            //int number = 10;
            //// number++  先使用后加一
            //// ++number  先加一后使用
            //// 等同于:number = number + 1;
            //Console.WriteLine(number++);   // 10
            //Console.WriteLine(++number);   // 12

            //// number--  先使用后减一
            //// --number  先减一后使用
            //// 等同于:number = number + 1;
            //Console.WriteLine(number--);
            //Console.WriteLine(--number);
            //Console.ReadKey();
            #endregion

            #region 判别符号放前与放后的区别

            // 放前:先加减,加减完后再使用
            // 放后:先使用,使用完后再加减
            // 最终的值都是要加减一的

            //int number = 10;
            //int number2 = 10;
            //int result = 10 + number++;    // 先使用后加一   20
            //int result2 = 10 + ++number2;   // 先加一后使用  21
            //Console.WriteLine(number);    // 11
            //Console.WriteLine(result);    // 20
            //Console.WriteLine(number2);    // 11
            //Console.WriteLine(result2);    // 21
            //Console.ReadKey();

            //// result = 10 + ++number等效于:
            //int number = 10;
            //number++;
            //int result = 10 + number;
            //Console.WriteLine(number);   // 11
            //Console.WriteLine(result);  // 21
            //Console.ReadKey();

            //// result = 10 + number++等效于:
            //int number = 10;
            //int result = 10 + number;
            //number++;
            //Console.WriteLine(number);   // 11
            //Console.WriteLine(result);  // 20
            //Console.ReadKey();

            //// result = 10 + --number等效于:
            //int number = 10;
            //number--;
            //int result = 10 + number;
            //Console.WriteLine(number);   // 9
            //Console.WriteLine(result);  // 19
            //Console.ReadKey(); 

            //// result = 10 + number--等效于:
            //int number = 10;
            //int result = 10 + number;
            //number--;
            //Console.WriteLine(number);   // 9
            //Console.WriteLine(result);  // 20
            //Console.ReadKey();

            //int a = 5;
            //int b = a++ + ++a * 2 + --a + a++;  // 相当于:5+7*2+6+6=>5+14+12=31
            //Console.WriteLine(a);   // 7
            //Console.WriteLine(b);   // 31
            //Console.ReadKey();


            #endregion
        }
    }
}
