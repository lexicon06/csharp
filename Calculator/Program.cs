using System;
using System.Linq;

namespace Main
{
    class Program
    {
        static bool calc = true;
        const string Author = "Pablo Ignacio Santillan";

        static readonly string[] valid_operations = {"+", "-", "*", "/"};
        static void Main(string[] args)
        {
            while(calc)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Calculator v1.0 created by {Author}");
                Console.WriteLine("-----------------");
                Console.WriteLine("Enter a number");
                int number_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number");
                int number_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an operator");
                string operation = Console.ReadLine();
                bool containsValidOperation = valid_operations.Any(op => operation.Contains(op));
                while(!containsValidOperation){
                    Console.WriteLine("Invalid operation Please Enter a valid operator such as "+string.Join(", ", valid_operations));
                    operation = Console.ReadLine();
                    containsValidOperation = valid_operations.Any(op => operation.Contains(op));
                }
                Console.WriteLine($"So far you have entered: {number_1} {operation} {number_2}");
                
                // Calculation part
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result: {number_1 + number_2}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {number_1 - number_2}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {number_1 * number_2}");
                        break;
                    case "/":
                        if (number_2 != 0)
                            Console.WriteLine($"Result: {number_1 / number_2}");
                        else
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        break;
                }
                
                Console.WriteLine("");
            }
        }
    }
}
