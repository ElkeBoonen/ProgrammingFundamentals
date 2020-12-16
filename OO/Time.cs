using System;
using System.Collections.Generic;
using System.Text;

namespace OO
{
    public class Time
    {
        int _hours;
        int _minutes;

        public Time(int h, int m)
        {
            Hours = h;
            Minutes = m;
        }

        public Time(Time t, int add)
        {
            Hours = t.Hours + add;
            Minutes = t.Minutes;
        }

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if ((value >= 0) && (value <= 23)) _hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if ((value >= 0) && (value <= 59)) _minutes = value;
            }
        }

        public override string ToString()
        {
            return Hours + ":" + Minutes;
        }

    }
}
