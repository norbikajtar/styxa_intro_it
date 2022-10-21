using System;

namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            name = WriteTextIfEmpty(name);

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            age = WriteTextIfEmpty(age);

            Console.WriteLine("What month were you born in?");
            var month = Console.ReadLine();

            month = WriteTextIfEmpty(month);

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if (month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (month == "april")
            {
                Console.WriteLine("you are a Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("you are a Gemini.");
            }
        }

        public static string WriteTextIfEmpty(string text)
        {
            if (text == "")
            {
                Console.WriteLine("Please type something already!");
                return Console.ReadLine();
            }
            else
            {
                return text;
            }
        }
    }
}
