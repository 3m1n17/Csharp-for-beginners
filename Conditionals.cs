/*If-Else Examples*/
using System;
class Program
{
    static void Main(string[] args)
    {
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
/*Switch Case Example*/
class SwitchExample
{
    static void Main(string[] args)
    {
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("Weekend");
                break;
        }
    }
}
/*Ternary Operator Example*/
class TernaryExample
{
    static void Main(string[] args)
    {
        int number = 5;
        string result = (number % 2 == 0) ? "Even" : "Odd";
        Console.WriteLine(result);
    }
}
/*Nested If Example*/
class NestedIfExample
{
    static void Main(string[] args)
    {
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
        }
        else
        {
            Console.WriteLine("The number is not positive.");
        }
    }
}

