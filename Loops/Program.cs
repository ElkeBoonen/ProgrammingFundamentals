using System;
using System.Runtime.CompilerServices;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x? ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result;

            //increment
            Console.WriteLine("FOR - 0 <= 10");
            for (int i = 0; i <= 10; i++)
            {
                result = i * x;
                Console.WriteLine("{0} * {1} = {2}", i, x, result);
            }

            //decrement
            Console.WriteLine("\n\nFOR - 10 >= 0");
            for (int i = 10; i >= 0; i--)
            {
                result = i * x;
                Console.WriteLine("{0} * {1} = {2}", i, x, result);
            }

            //step size 2
            Console.WriteLine("\n\nFOR - 0 <= 10 - step size 2");
            for (int i = 0; i <= 10; i=i+2) //i+=2
            {
                result = i * x;
                Console.WriteLine("{0} * {1} = {2}", i, x, result);
            }

            //table of stars
            Console.WriteLine("\n\nNESTED FOR LOOPS");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //ask the user to continue
            Console.WriteLine("\n\nWHILE - ask user for input");
            Console.Write("Next? yes to continue!: ");
            string answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.Write("Next? yes to continue!: ");
                answer = Console.ReadLine();
            }


            //3^0 3^1 3^2 3^3...
            //1 3 9 81...
            //10^0 10^1 10^2 10^3...
            //1 10 100 1000...
            Console.Write("\n\nWHILE - start with 1 (print before): ");
            result = 1;
            while (result < 10000)
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                Console.Write(result + " ");
                result = result * x;
            }

            Console.Write("\n\nWHILE - start with 1 (print after): ");
            result = 1;
            while (result < 10000)
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                result = result * x;
                Console.Write(result + " ");
            }

            Console.Write("\n\nWHILE - start with x (print before): ");
            result = x;
            while (result < 10000)
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                Console.Write(result + " ");
                result = result * x;
            }


            Console.Write("\n\nDO WHILE - start with x (print before): ");
            result = x;
            do
            {
                if ((x == 0) || (Math.Abs(x) == 1)) break;
                Console.Write(result + " ");
                result = result * x;
            } while (result < 10000) ;

        }
    }
}
