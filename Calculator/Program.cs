
do
{
    double num1 = 0;
    double num2 = 0;
    double result = 0;

    Console.WriteLine("------------------");
    Console.WriteLine("Calculator program");
    Console.WriteLine("------------------");

    Console.Write("Enter number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter number 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter an operation: ");
    Console.WriteLine("\t\"+\" : Add");
    Console.WriteLine("\t\"-\" : Subtraction");
    Console.WriteLine("\t\"/\" : Multiply");
    Console.WriteLine("\t\"*\" : Divide");

    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
            break;
        default:
            Console.WriteLine("Invalid operation entered");
            break;
    }

    Console.WriteLine("Would you like play again (Y/N): ");

} while (Console.ReadLine()!.ToUpper().Equals("Y"));

Console.WriteLine("Press any key to exit...");

Console.ReadKey();