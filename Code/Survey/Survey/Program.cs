using System;

namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();

            Display(name, age, month);
        }

        public static void Display(string name, int age, string month)
        {
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            switch (month.ToLower())
            {
                case "march":
                    Console.WriteLine("you are an Aries.");
                    break;
                case "april":
                    Console.WriteLine("you are a Taurus.");
                    break;
                case "may":
                    Console.WriteLine("you are a Gemini.");
                    break;
            }
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();

            while (string.IsNullOrEmpty(question))
            {
                Console.WriteLine("You didn't type anything, please try again:");
                question = Console.ReadLine();
            }

            return question;
        }
    }
}
