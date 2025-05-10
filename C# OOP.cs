using System;
namespace OOP
{
    // Define a class
    class Person
    {
        // Properties (fields)
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Method
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
    class Program
    {
        static void Main()
        {
            Person person1 = new Person("Emin", 18);
            Person person2 = new Person("Alex", 21);
            person1.Greet();
            person2.Greet();
        }
    }
}
