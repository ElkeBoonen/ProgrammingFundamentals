using System;
using System.Collections.Generic;
using System.Text;

namespace OO
{
    public class Person
    {
        public string Name { get; set; }
        protected DateTime Birth { get; set; }

        public Person()
        {
            Name = "John Doe";
            Birth = DateTime.Now;
        }
        public Person(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }
        public int CalculateAge()
        {
            return DateTime.Now.Year - Birth.Year;
        }

        public virtual void Print()
        {
            Console.WriteLine("HELLO " + Name + "  " + Birth);
        }

        public override string ToString()
        {
            return Name + " is " + CalculateAge() + " years old" ; 
        }
    }
}
