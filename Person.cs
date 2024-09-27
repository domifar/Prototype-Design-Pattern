using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
    class Person : Prototype
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() { }
        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
        }

        public Prototype Clone()
        {
            return new Person(this);
        }

        public override string ToString()
        {
            return $"\nName: {Name} \nAge: {Age}";
        }
    }
}