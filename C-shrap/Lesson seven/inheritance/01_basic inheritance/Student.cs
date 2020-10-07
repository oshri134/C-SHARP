using System;

namespace Lesson07
{
    class Student : Person
    {
        // Property:
        private float avgGrade;
        public float AvgGrade
        {
            get { return avgGrade; }
            set { avgGrade = value; }
        }
    }
}
