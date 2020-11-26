using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number of lines: ");
                int nr = Convert.ToInt32(Console.ReadLine());
                StreamReader file = File.OpenText("englih.txt");
                for (int i = 0; i < nr; i++)
                {
                    Console.WriteLine(file.ReadLine());
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Oops: file not found!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Oops: wrong number!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Uh-oh! Something went wrong: " + e.Message);
            }
           
            
        }
    }
}
