using System;

namespace PersonClass
{
    class Program
    {
        public class Person
        {
            public string Name;

            public void Introduce(string to)
            {
                Console.WriteLine($"Hi {to}, I am {Name}");
            }

            // We are creating a personal object from a string
                // We create a parse method
            public static Person Parse(string str)
            {
                var person = new Person();
                person.Name = str;

                return person;
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
