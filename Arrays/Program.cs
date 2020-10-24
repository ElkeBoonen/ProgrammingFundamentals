using System;
using System.Diagnostics.CodeAnalysis;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[6];
            ages[1] = 10;
            ages[1] = 11;
            Console.WriteLine(ages[0] + " " + ages[1] + " " + ages[2]);
            
            string[] names = { "tuur", "jan", "mies", "bob" };
            Console.WriteLine("Length of array: " + names.Length);
            Console.WriteLine(names[0] + " " + names[1] + " " + names[2] + " " + names[3]);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int index = 0;
            while (index < names.Length)
            {
                Console.WriteLine(names[index]);
                index++;
            }

            Console.Write("Enter number of students: ");
            int nr = Convert.ToInt32(Console.ReadLine());
            double[] points = new double[nr];
            for (int i = 0; i < nr; i++)
            {
                Console.Write("Enter grade for student " + i + ": ");
                points[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Enter all grades: ");
            string[] answers = (Console.ReadLine()).Split(' ');
            points = new double[answers.Length];
            for (int i = 0; i < answers.Length; i++)
            {
                points[i] = Convert.ToDouble(answers[i]);
            }

            Console.Write("Enter all names (seperated by a space): ");
            names = (Console.ReadLine()).Split(' ');
            Console.WriteLine("Number of names: " + names.Length);

            Console.Write("Enter all grades: ");
            answers = (Console.ReadLine()).Split(' ');
            double[] grades = Array.ConvertAll(answers, Double.Parse);

            Array.Sort(grades);
            foreach (double p in grades)
            {
                Console.Write(p + " ");
            }

            // sales figures - one month ( table ): 4 weeks , 7 days
            int[,] sales1 = new int[4, 7];
            int[,] sales = { { 22 ,39 ,4 ,93 ,0 ,22 ,32} ,
            { 9 ,8 ,67 ,51 ,5 ,3 ,56} ,
            { 14 ,8 ,23 ,14 ,5 ,23 ,16} ,
            { 54 ,0 ,76 ,31 ,4 ,3 ,99} };

            Console.WriteLine(sales[2, 3]);
            sales[2, 3]++;
            Console.WriteLine(sales[2, 3]);
            sales[2, 3] = 14;
            Console.WriteLine(sales[2, 3]);

            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.Write(sales[i, j] + "\t");
                }// after every row , take new line
                Console.WriteLine();
            }

            int sum = 0;
            foreach (int number in sales)
            {
                sum += number;
            }
            double average = sum / sales.Length;
            Console.WriteLine("Average daily sales: " + average);

            // number of rows need to be specified
            int[][] jaggedArray = new int[3][];

            // declare every rowsize , fill with elements
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            jaggedArray[0][0] = 1;
            jaggedArray[1][0] = 0;
            // ...

            // number of rows need to be specified
            jaggedArray = new int[3][];

            // or just fill the rows with elements
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            // or create the jagged array by filling all elements at once
            jaggedArray = new int[][] {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }};


            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
