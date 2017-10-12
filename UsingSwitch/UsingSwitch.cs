using System;

class UsingSwitch

{
    static void Main()
    {
        Console.WriteLine("Enter your score:");
        int score = int.Parse(Console.ReadLine());
        switch (score)
        {
            case 6:
                Console.WriteLine("Excellent");
                break;
            case 5:
                Console.WriteLine("Very good");
                break;
            case 4:
                Console.WriteLine("Good");
                break;
            case 3:
                Console.WriteLine("Average");
                break;
            case 2:
                Console.WriteLine("Bad");
                break;
        }

        Console.ReadLine();




    }
}

