using System.Collections.Generic;
using System.Linq;

namespace Util
{
    public class Console
    {
        public static void WriteLine(string text)
        {
            
        }

        public void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void Sum(int a, int b)
        {
            System.Console.WriteLine(a + b);
        }

        public void Sum(int a, int b, int c)
        {
            System.Console.WriteLine(a + b);
        }

        public void Sum(string a, string b)
        {
            System.Console.WriteLine(string.Concat(a, b));
        }

        public void Sum(List<int> a, List<int> b)
        {
            foreach (var item in a)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
