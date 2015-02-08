using System;
using System.Text;

namespace App2
{
    class Program
    {
        static void Main()
        {
            string message = "Hello world";
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);
            int x = 2015;
            message = message + x.ToString();
            Console.WriteLine(message);
            bool simpleVar = false;
            if (simpleVar)
                Console.WriteLine("This will not print");
            int y = 5000;
            bool lessThanAMile = y < 5280;
            if (lessThanAMile)
                Console.WriteLine("This will print");
        }
    }
}
