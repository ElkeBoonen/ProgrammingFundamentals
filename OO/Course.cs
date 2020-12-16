using System;
using System.Collections.Generic;
using System.Text;

namespace OO
{
    public enum WeekDays
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }

    public class Course
    {
        public string Name { get; set; }
        public Teacher Docent { get; set; }
        public string Room { get; set; }
        public int Hours { get; set; }
        public WeekDays Weekday { get; set; }
        public Time StartHour { get; set; }

        public Course(string n, Teacher t, string r, int h, WeekDays w, Time d)
        {
            Name = n; Docent = t; Room = r; Hours = h; Weekday = w; StartHour = d;
        }

        public override string ToString()
        {
            string s = "";
            s += "COURSE " + Name;
            s += "\n- " + Docent.Name;
            s += "\n- " + Room;
            s += "\n- " + Weekday;
            Time EndHour = new Time(StartHour, Hours);
            s += "\n- " + StartHour.ToString() + " -> " + EndHour.ToString();
            return s; 
        }
    }
}
