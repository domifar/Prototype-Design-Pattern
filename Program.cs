using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person { Name = "Dominik", Age = 17 };

            Person person2 = (Person)person1.Clone();

            Console.WriteLine("Klonen" + person1);
            Console.WriteLine("\nKlon" + person2);

            person2.Name = "Amar";
            person2.Age = 18;

            Console.WriteLine("\nNach Änderung des Klons");
            Console.WriteLine("\nOriginal" + person1);
            Console.WriteLine("\nKlon" + person2);
        }
    }
}