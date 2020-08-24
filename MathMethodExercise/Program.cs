using System;
using System.ComponentModel;

namespace MathMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets have some fun with addition!");

            Console.WriteLine("Give me a number");
            var firstNumber = Int32.Parse(Console.ReadLine());
    

            Console.WriteLine("Give me another");
            var secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Your answer is " + add(firstNumber, secondNumber));

        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public static int add(int a, int b, int c, int d, int e)
        {
            return a + b + c + d + e;
        }
    }
}
