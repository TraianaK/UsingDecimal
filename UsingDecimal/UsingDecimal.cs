using System;


class UsingDecimal
{
    static void Main()
    {
        bool isInputValid = true;

        Console.WriteLine("Please enter number 1 : ");
        float number1 = 0;

        try
        {
            number1 = float.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("First number is not number.");
            isInputValid = false;
        }

        float number2 = 0;
        if (isInputValid)
        {

            Console.WriteLine("Please enter number 2 : ");
            if (!float.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Second number is not number.");
                isInputValid = false;
            }
        }

        Console.WriteLine("Please select an operation : ");
        Console.WriteLine("1 for (+)");
        Console.WriteLine("2 for (-)");
        Console.WriteLine("3 for (*)");
        Console.WriteLine("4 for (/)");

        Console.WriteLine("Your choice : ");
        string operation = Console.ReadLine();

        float result = 0;
        string operationAsString = "";

        if (operation == "1") ;
        {
            result = number1 + number2;
            operationAsString = " + ";
        }
        if (operation == "2")
        {
            result = number1 - number2;
            operationAsString = " - ";
        }
        if (operation == "3")
        {
            result = number1 * number2;
            operationAsString = " * ";
        }
        if (operation == "4")
         {
            result = number1 / number2;
            operationAsString = " / ";
        }


        Console.WriteLine("Result is {0} {1} {2} = {3}",
        number1,
        operationAsString,
        number2,
        result);

        Console.ReadLine();
        }
}
        
