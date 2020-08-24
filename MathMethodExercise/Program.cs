using System;
using System.ComponentModel;

namespace MathMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            AdditionCalculator(); 
          
        }

        public static void AdditionCalculator() {
            Console.WriteLine("Lets have some fun with addition!");

            Console.WriteLine("Give me a number: ");
            var firstNumber = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Give me another: ");
            var secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Do we want to add a third number? Yes or No");
            var reply = Console.ReadLine();

            if (reply == "Yes") {
                Console.WriteLine("Okay, what is the third number?");
                var thirdNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Your answer is " + Sum(firstNumber, secondNumber, thirdNumber));
            } else {
                Console.WriteLine("Your answer is " + Sum(firstNumber, secondNumber));
            }

        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int product(params int[] list)
        {
            int product = 0;
            for(int i = 0; i < list.Length; i++)
            {
                product = product * list[i];
            }
            return product;
        }
    }
}
