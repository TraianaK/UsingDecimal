using System;

class MoneyTask
{
    static void Main()
    {
        Console.WriteLine("Enter how much money you have: (int 1....1000000)");
        int money = int.Parse(Console.ReadLine());

        if (money > 100000)
        {
            Console.WriteLine("Please buy me a plane");
        }
        else if (money > 10000)
        {
            Console.WriteLine("Please buy me a car");
        }
        else if (money > 100)
        {
            Console.WriteLine("Please buy me an ice cream");
        }
        else if (money > 10)
        {
            Console.WriteLine("I don't talk to strangers");
        }


    }

}


