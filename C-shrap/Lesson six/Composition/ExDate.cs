using System;

namespace Lesson06
{
    class ExDate
    {
        // composition: allow class to contain object instances in other classes, so they can be used in other class. 

        private int day;
        public int Day
        {
            get { return day; }
            set {
                if(value > 0 && value < 32)
                    day = value; 
            }
        }

        private int month;
        public int Month
        {
            get { return month; }
            set {
                if (value > 0 && value < 13)
                    month = value; 
            }
        }

        private int year;
        public int Year
        {
            get { return year; }
            set {
                if (value > 2000 && value < 2200)
                    year = value; 
            }
        }


        // constructor:
        public ExDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // methods
        public override string ToString()
        {
            return $"Date: {day}/{month}/{year}";
        }
    }
}
