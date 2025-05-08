/*For loops*/
using System;
class Forloop
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

/*While loops*/
class Whileloop
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
/*Do while loops*/
class Dowhileloop
{
    static void Main(string[] args)
    {
        int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);
    }
}
/*Break*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Using break to exit loop early:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Breaking the loop at i = 5");
                break; 
            }
            Console.WriteLine($"i = {i}");
        }
    }
}
/*Continue*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Using continue to skip even numbers:");

        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                continue; 
            }
            Console.WriteLine($"i = {i}"); 
        }
    }
}


