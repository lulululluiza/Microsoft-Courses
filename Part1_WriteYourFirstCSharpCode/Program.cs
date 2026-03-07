using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_WriteYourFirstCSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //char, single character, use ''
            Console.WriteLine('A');
            //Console.WriteLine('ABC'); this doesnt work

            //int
            Console.WriteLine(1);

            //floating point decimals by order of precision
            Console.WriteLine(1.11f); //float, f or F works
            Console.WriteLine(1.11); //double
            Console.WriteLine(1.11m); //decimal

            //boolean
            Console.WriteLine(true);


            //declaring variables
            string firsName;
            string _lastName; //allowed but use for other convention

            firsName = "Bob";
            Console.WriteLine(firsName);
            firsName = "Lia";
            Console.WriteLine(firsName);

            string middleName = "Maria";
            Console.WriteLine(middleName);

            //declaring implicitly variables  
            //var something; //var MUST be initialized 
            var message = "Hey there"; //it interprets the var as string
            Console.WriteLine(message);
            message = "Hey there!!!";
            Console.WriteLine(message);
            //message = 0; //since it interprets originally as string, you cant convert


            //Challenge
            string name = "Bob";
            int valueSimple = 3;
            float valuePoint = 34.4f;
            Console.WriteLine($"Hello, {name}! You have {valueSimple} messages in your inbox. The temperature is {valuePoint} celsius.");



        }
    }
}
