using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String formatting

            string firstName = "Bob";
            int calls = 14;
            string message = $"Hello {firstName}! You have {calls} calls missed O.O";
            Console.WriteLine(message);

            string projectName = "Project Zero";
            Console.WriteLine($@"C:\User\Projects\{projectName}\Data"); //this way \ is exhibited


            //Challenge - sadly vs studio terminal doesn't display cyrillic very well...
            string projectNameAgain = "ACME";
            string messageRussian = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

            Console.WriteLine("View English output:");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine($@"c:\Exercise\{projectNameAgain}\data.txt");

            Console.WriteLine();

            Console.WriteLine($@"{messageRussian}");
            Console.Write(" ");
            Console.Write(" ");
            Console.WriteLine($@"c:\Exercise\{projectNameAgain}\ru-RU\data.txt");

        }
    }
}
