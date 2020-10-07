using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson07
{
    class Person
    {
            // אב - טיפוס מחלקה ראשית

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

            // constructor:
            public Person(int id, string name)
            {
                Id = id;
                Name = name;
            }

            // all classes inherit from the Object class
            public override string ToString()
            {
                return $"Person id: {id}, name: {name}";
            }
        }
    }
