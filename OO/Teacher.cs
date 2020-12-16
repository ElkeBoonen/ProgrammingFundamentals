using System;
using System.Collections.Generic;
using System.Text;

namespace OO
{
    public class Teacher : Person
    {
        public Teacher(string name, DateTime birth) : base(name, birth)
        {
        }
        public override void Print()
        {
            Console.WriteLine("HELLO TEACHER " + Name + "  " + Birth);
        }
    }
}
