using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User! Write down the name of the person you know:");
            string name = Console.ReadLine();

            Console.WriteLine("Ok! Now write the favorite color:");
            string color = Console.ReadLine();

            Console.WriteLine("Which country was raised?");
            string country = Console.ReadLine();

            Console.WriteLine("What`s the favorite thing?");
            string thing = Console.ReadLine();

            Console.WriteLine("What time does this person sleep?");
            var hour = Convert.ToInt32 (Console.ReadLine());

            int years = Age(13, 20);
            int num = Brothers(1, 2);

            Console.WriteLine($"Ok! That`s enough info! I know this person! I know this {name}, she lives in Texas, she is {years} years old, she has {num} brothers, her favorite color is {color}, she was raised in {country} and she loves not only {thing} but also coke, chilli, Valentina Sauce and sleeps everyday really early! Around {hour} o`clock!");
        }

        public static int Age(int num1, int num2)
        {
            return (num1 + num2);
        }

        public static int Brothers(int num1, int num2)
        {
            return (num1* num2);
        }
       

    }
}
