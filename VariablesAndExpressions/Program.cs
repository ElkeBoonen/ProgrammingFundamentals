using System;

namespace VariablesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            double lengthObject, widthObject;
            char firstLetterOfAlphabet;
            string myName = "elke";
            int myAge = 40;

            number = 5;
            lengthObject = 5.6;
            widthObject = 8.4;
            firstLetterOfAlphabet = 'a';

            widthObject = 1.2;
            lengthObject = widthObject;
            myName = "elke boonen";
            number = myAge;
            number = 10;

            int a, b, c;
            a = 5; //value
            b = a; //variable
            c = a * b; //calculation

            a++;
            ++a;

            a--;
            --a;

            int i = 3;
            Console.WriteLine(i); // output : 3
            Console.WriteLine(i++); // output : 3
            Console.WriteLine(i); // output : 4
            double d = 1.5;
            Console.WriteLine(d); // output : 1.5
            Console.WriteLine(++d); // output : 2.5
            Console.WriteLine(d); // output : 2.5

            Console.WriteLine(8 + 2); // output : 10
            Console.WriteLine(8 - 2); // output : 6
            Console.WriteLine(8 * 2); // output : 16
            Console.WriteLine(7.0 / 2.0); // output : 3.5
            Console.WriteLine(7 / 2.0); // output : 3.5
            Console.WriteLine(7 / 2); // output : 3 (integer division, no digits after point)
            
            // modulo - remainder after integer division
            //7 / 2 = 3 --> (7 - 2 * 3) = 1
            Console.WriteLine(7 % 2); // output : 1

            myName = "Elke";
            myName = myName + "Boonen";
            Console.WriteLine("My name is " + myName); //output My Name is Elke Boonen

            Console.WriteLine(5 + 5); // output : 10
            Console.WriteLine("5" + 5); // output : 55
            Console.WriteLine(5 + "5"); // output : 55

            int nr = 5;
            double dec = nr + 0.5; // implicit to double
            Console.WriteLine(dec); // implicit to string

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("You are " + age + " yrs old ");
            int intAge = Convert.ToInt32(age);
            int year = DateTime.Now.Year - intAge;
            Console.WriteLine("Birth year: " + year);

            Console.Write("Give me a random character: ");
            int ascii = Console.Read();
            Console.WriteLine("ASCII value char: " + ascii); // implicit to string
            char ch = (char)ascii;
            Console.WriteLine("Character pressed: " + ch);

        }
    }
}
