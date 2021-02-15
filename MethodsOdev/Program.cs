using System;
using System.Linq;

namespace MethodsOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //add();
            //add1(20,30);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = add2(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            Console.WriteLine(multiple(2,4,5));
            Console.WriteLine(add3(1,2,3,5,4,6,9,8,41));
            Console.WriteLine("Hello World!");
        }

        static void add()
        {
            Console.WriteLine("Added");
        }
        static void add1( int number1,int number2)
        {
           var result = number1 + number2;
            
            return;
        }

        static int add2(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int multiple(int number1,int number2)
        {
            return number1 * number2;
        }
        static int multiple(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int add3(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
