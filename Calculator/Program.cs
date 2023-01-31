using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("введите первое число");
            double numberOne = InputCheck();
            Console.WriteLine("введите действие");
            string action = Console.ReadLine();
            Console.WriteLine("введите второе число");
            double numberTwo = InputCheck();
            Actions(action, numberOne, numberTwo);
        }
    }
    static void Actions(string action, double numberOne, double numberTwo)
    {
        if (action == "+")
            Console.WriteLine("Result: " + (numberOne + numberTwo));
        if (action == "-")
            Console.WriteLine("Result: " + (numberOne - numberTwo));
        if (action == "*")
            Console.WriteLine("Result: " + (numberOne * numberTwo));
        if (action == "/")
            if (numberTwo == 0)
                Console.WriteLine("Error,you can't divide by 0");
            else
                Console.WriteLine("Result: " + (numberOne / numberTwo));
        if (action == "%")
            Console.WriteLine("Result: " + Math.Round(((numberOne / numberTwo) * 100), 1));
        if (action == "^")
            Console.WriteLine("Result: " + Math.Pow(numberOne, numberTwo));
    }

    static double InputCheck()
    {
        while(true)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                return number;
            }
            catch
            {
                Console.WriteLine("it's not a number!!!!!!!!! Try again:)");
            }
        }
    }
}