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
