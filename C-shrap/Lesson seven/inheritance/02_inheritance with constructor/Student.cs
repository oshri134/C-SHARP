using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson07
{
    class Student : Person
    {
        // Properties:
        private int numOfClasses;
        public int NumOfClasses
        {
            get { return numOfClasses; }
            set { numOfClasses = value; }
        }

        // constructor:
        public Student(int numOfClasses, int id, string name):base(id, name)
        {
            NumOfClasses = numOfClasses;
        }

        // toString()

        public override string ToString()
        {
            return base.ToString() + $" NumOfClasses: {NumOfClasses}";
        }
    }
}
