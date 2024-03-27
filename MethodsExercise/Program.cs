using System;

namespace MethodsExercise
{

    class program
    {


        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }

        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }

        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }

        static void Main(string[] args)
        {
            var AmountOfPens = Add(4, 7);
            var answer = (AmountOfPens);
            Console.WriteLine(answer);

            var multiply = Multiply(3, 3);
            var answer1 = (multiply);
            Console.WriteLine(answer1);

            var divide = Divide(27, 3);
            var answer2 = (divide);
            Console.WriteLine(answer2);

            var minus = Subtract(99, 33);
            var answer3 = (minus);
            Console.WriteLine(answer3);

            Console.WriteLine("What is your name");
            var UserName = Console.ReadLine();

            Console.WriteLine($"Hi {UserName}, what is your favorite color");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is cool, what is your favorite animal");
            var animal = Console.ReadLine();

            Console.WriteLine("what is your favorite band");
            var band = Console.ReadLine();

            Console.WriteLine($"Once a man named {UserName} bought a {color} colored {animal} to go see the band {band}");
        }
    }
}
