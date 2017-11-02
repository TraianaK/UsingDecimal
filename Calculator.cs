using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Please enter a number A = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number B =  ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose an operation - , + , * or /.");
            string operation = Console.ReadLine();

            if (operation == "*")
            {
                Console.WriteLine("The result is : {0}", a * b);
            }
            else if (operation == "/")
            {
                Console.WriteLine("The result is : {0}", a / b);
            }
            else if (operation == "+")
            {
                Console.WriteLine("The result is : {0}", a + b);
            }
            else if (operation == "-")
            {
                Console.WriteLine("The result is : {0}", a - b);
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }

            Console.WriteLine("Do you want to continue ?");
            string option = Console.ReadLine();
           
            if (option == "no")
            {
                break;
            }
            else if (option == "yes")
            {
            }
            else
            {
                Console.WriteLine("Invalid option");
                break;
            }
        }
    }
}



