using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x :");
            string answer = Console.ReadLine();
            int x;
            bool succes = Int32.TryParse(answer, out x);

            if (!succes)
            {
                Console.WriteLine("Oopsie, try again");
                return;
            }
            
            int y = 18;

            //variation 1
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x == y)
            {
                Console.WriteLine("x is equal to y");
            }
            else
            {
                Console.WriteLine("x is less than y");
            }

            //variation 2
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else if (x < y)
            {
                Console.WriteLine("x is less than y");  
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }

            //variation 3 - nest if structures
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }
            else
            {
                if (x < y)
                {
                    Console.WriteLine("x is less than y");
                }
                else
                {
                    Console.WriteLine("x is equal to y");
                }
            }

            //variation 4
            if ((x < y) || (x > y))
            {
                Console.WriteLine("x is not equal to y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }

            //variation 5
            if (x!=y)
            {
                Console.WriteLine("x is not equal to y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }

            //variation 6
            bool result = x != y;
            if (result)
            {
                Console.WriteLine("x is not equal to y");
            }
            else
            {
                Console.WriteLine("x is equal to y");
            }

            DateTime today = DateTime.Now;
            int weekday = Convert.ToInt32(today.DayOfWeek);
            Console.WriteLine(weekday);

            if (weekday == 1)
            {
                Console.WriteLine("It's Monday");
            }
            else if (weekday == 2)
            {
                Console.WriteLine("It's Tuesday");
            }
            else if (weekday == 3)
            {
                Console.WriteLine("It's Wednesday");
            }
            else if (weekday == 4)
            {
                Console.WriteLine("It's Thursday");
            }
            else if (weekday == 5)
            {
                Console.WriteLine("It's Friday");
            }
            else if ((weekday == 6) || (weekday == 7))
            {
                Console.WriteLine("It's Weekend");
            }
            else
            {
                Console.WriteLine("It's a crazy day");
            }

            switch (weekday)
            {
                case 1: Console.WriteLine("It's Monday");
                    break;
                case 2: Console.WriteLine("It's Tuesday");
                    break;
                case 3: Console.WriteLine("It's Wednesday");
                    break;
                case 4: Console.WriteLine("It's Thursday");
                    break;
                case 5: Console.WriteLine("It's Friday");
                    break;
                case 6:
                case 7: Console.WriteLine("It's Weekend");
                    break;
                default: Console.WriteLine("It's a crazy day");
                    break;
            }


        }
    }
}
