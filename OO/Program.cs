using System;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person john = new Person();
            john.Print();
            Person elke = new Person("Elke", new DateTime(1980, 4, 23));
            elke.Print();
            Console.WriteLine(elke.Name + " is " + elke.CalculateAge() + " years old");
            Console.WriteLine(elke.ToString());

            Person[] people = { new Person("Thomas", new DateTime(1980, 6, 23)),
                                new Person("Jef", new DateTime(2000, 9, 12)),
                                new Teacher("Marie", new DateTime(1974, 7, 2)) };

            foreach (Person p in people)
            {
                p.Print();
            }

            Teacher tom = new Teacher("Tom", new DateTime(1976, 1, 1));
            Teacher marie = new Teacher("Marie", new DateTime(1965, 12, 12));
            Course pr = new Course("Programming", tom, "C3.05", 3, WeekDays.Monday, new Time(8, 30));
            Course db = new Course("Databases", tom, "C3.05", 3, WeekDays.Thursday, new Time(10, 30));
            Course sc = new Course("Scripting", marie, "C2.05", 3, WeekDays.Monday, new Time(13, 00));

            Student jef = new Student("Jef", new DateTime(2000, 9, 12), new Course[] { pr, db, sc });

            Person[] people = { new Person("Thomas", new DateTime(1980, 6, 23)),
                                tom,
                                marie,
                                jef };

            foreach (Person p in people)
            {
                p.Print();
            }*/

            RPS game = new RPS();

            string answer;
            Console.WriteLine("Rock (0), Paper (1), Scissors (2) - (S to stop)");

            while ((answer = Console.ReadLine()) != "S")
            {
                game.Me = (Hand)Convert.ToInt32(answer);
                string result = game.Turn();
                Console.WriteLine(result);
            }
            Console.WriteLine($"Final score {game.ToString()}");


        }
    }
}
