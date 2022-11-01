using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");

            try
            {
                data.Age = TryAnswerNumber();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("The argument you provided is NULL!");
            }
            catch (Exception e)
            {
                Console.WriteLine("The age you provided is in an incorrect format!");
                data.Age = int.Parse(TryAnswer());
            }

            Console.WriteLine("What month were you born in?");
            data.Month = TryAnswer();

            data.Display();
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                throw new ArgumentNullException();
            }
            return question;
        }

        static int TryAnswerNumber()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                throw new ArgumentNullException();
            }

            int result;

            try
            {
                result = int.Parse(question);
            }
            catch (Exception e)
            {
                result = TryAnswerNumber();
            }

            return result;
        }
    }
}