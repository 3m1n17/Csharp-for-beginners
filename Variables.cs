using System;
class Program
{
    static void Main()
    {
        int age = 18;
        string name = "Emin";
        double height = 1.70;
        bool isStudent = true;

        Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Student: {isStudent}");
    }
}
/* ConstantsExample below */
class ConstantsExample
{
    const double PI = 3.14;
    const string GREETING = "Hello, World!";

    static void Main()
    {
        Console.WriteLine($"PI: {PI}");
        Console.WriteLine(GREETING);
    }
}
/* InputExample below */
class InputExample
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hello, {name}. You are {age} years old.");
    }
}
/* MathExample */
class MathExample
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int sum = a + b;
        int product = a * b;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}
/* StringExample */
class StringExample
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        string combined = str1 + " " + str2;
        Console.WriteLine(combined);
    }
}
