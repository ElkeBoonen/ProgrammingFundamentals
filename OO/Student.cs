using System;
using System.Collections.Generic;
using System.Text;

namespace OO
{
    public class Student : Person
    {
        public Course[] Courses { get; set; }
        public Student(string name, DateTime birth, Course[] c) : base(name, birth)
        {
            Courses = c;
        }
        public override void Print()
        {
            Console.WriteLine("HELLO STUDENT " + Name + "  " + Birth);
            foreach (var item in Courses)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
