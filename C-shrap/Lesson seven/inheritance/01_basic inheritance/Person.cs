using System;

namespace Lesson07
{
    class Person
    {

        // אב - טיפוס מחלקה ראשית
        private static string country;
        public static string Country
        {
            get { return country; }
            set { country = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isMale;
        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }
    }
}
