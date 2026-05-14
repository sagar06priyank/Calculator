using System.Transactions;

public class Calculator
{
    public static void Main()
    {
        char d;
        do
        {
            int a,b;
            Console.WriteLine("Enter the first number");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Please enter a valid integer:");
            }
                Console.WriteLine("You have entered first numberrrrrr: " + a);

            Console.WriteLine("Enter the second number");
            
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Please enter a valid integer:");
            }
                Console.WriteLine("You have entered second number: " + b);

            Console.WriteLine("Enter one of the following operations (+,-,*,/)");
            char op = Convert.ToChar(Console.ReadLine());
            int c;



            switch (op)

            {
                case '+':
                    c = a + b;
                    Console.WriteLine("The result is " + c);
                    break;

                case '-':
                    c = a - b;
                    Console.WriteLine("The result is " + c);
                    break;

                case '*':
                    c = a * b;
                    Console.WriteLine("The result is " + c);
                    break;

                case '/':
                    try
                    {
                    c = a / b;
                    Console.WriteLine("The result is " + c);
                    }
                    catch (DivideByZeroException)
                    {
                    Console.WriteLine("Cannot divide by zero");
                    }
                    break;

                default:
                    Console.WriteLine("The operation is not valid");
                    break;

            }

            Console.WriteLine("Do you wish to continue(y/n)");
            d = Convert.ToChar(Console.ReadLine());
            Console.Clear();
        }
        while (d == 'y');
        Console.ReadKey();


    }
}
