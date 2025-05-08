/*MethodExample*/
using System;
class MethodExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int result = Add(5, 10);
        Console.WriteLine("The sum is: " + result);
    }
    static int Add(int a, int b)
    {
        return a + b;
    }
}

