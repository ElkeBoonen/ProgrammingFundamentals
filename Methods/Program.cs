using System;

namespace Methods
{
    class Program
    {
        static void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(double[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Print(string[] words)
        {
            foreach (var item in words)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] Fill(int size=10)
        {
            Random rd = new Random();
            int[] array = new int[size]; 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(-20, 21);
            }
            return array;

            Array.Sort(array); //will never get executed!!!
        }

        static void ChangeValue(int x)
        {
            x = 200;
            Console.WriteLine(x);
        }

        static void ChangeValue(int[] arrayX)
        {
            arrayX[0] = 200;
            Print(arrayX);
        }

        static void SwapValue(int a, int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void SwapRef(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int[] nrs1 = { 4, 5, 1, 0, 2, 3 };
            Print(nrs1);
            Array.Sort(nrs1);
            Print(nrs1);

            int[] nrs2 = Fill();
            Print(nrs2);
            Array.Sort(nrs2);
            Print(nrs2);

            int[] nrs3 = Fill(20);
            Print(nrs3);
            Array.Sort(nrs3);
            Print(nrs3);

            string[] words = { "banana", "apple", "lemon" };
            Print(words);
            Array.Sort(words);
            Print(words);

            double[] nrs4 = { 1.2,1.0,1.01 };
            Print(nrs4);
            Array.Sort(nrs4);
            Print(nrs4);

            int i = 100;
            Console.WriteLine(i);
            ChangeValue(i);
            Console.WriteLine(i);

            int[] arrayX = { 100, 0, 100 };
            Print(arrayX);
            ChangeValue(arrayX);
            Print(arrayX);

            int a = 6;
            int b = 8;
            Console.WriteLine($"a:{a} and b:{b}");

            SwapValue(a, b);
            Console.WriteLine($"a:{a} and b:{b}");

            SwapRef(ref a, ref b);
            Console.WriteLine($"a:{a} and b:{b}");

            Console.Write("Enter array size: ");
            string answer = Console.ReadLine();
            int size; // create a variable
            int[] array;
            if (Int32.TryParse(answer, out size))
            {
                array = Fill(size); // answer is parsed into size
            }
            else
            { // tryParse failed
                array = Fill(); // array with 10 elements = default
            }
            Print(array);

        }

   
    }
}
