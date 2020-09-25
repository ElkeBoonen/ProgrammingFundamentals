using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //text between " " 
            //We import the System namespace by using-statement
            System.Console.Write('h'); //single characters between ' ' 
            //write text without newlines!
            Console.Write(' ');
            Console.Write('e');
            Console.Write(' ');
            Console.Write('l');
            Console.Write(' ');
            Console.Write('l');
            Console.Write(' ');
            System.Console.WriteLine('o');
            //numbers without quotes
            Console.WriteLine(0);
            //decimal point, not a comma
            Console.WriteLine(0.5);
            //true or false without quotes
            Console.WriteLine(true);
            Console.WriteLine(false);

        }
    }
}
