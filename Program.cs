 Console.ForegroundColor = ConsoleColor.White;
 Console.Title = "Basic Calc";

// This is an example of a comment, it is not included when the program operates.


Console.WriteLine("[1] Addition");
Console.WriteLine("[2] Subtraction");
Console.WriteLine("[3] Multiplication");
Console.WriteLine("[4] Division");

string op = Console.ReadLine();

if (op == "1")
{
    double num01;
    double num02;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Enter your first number: ");
    num01 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter your second number: ");
    num02 = Convert.ToDouble(Console.ReadLine());

    double result = num01 + num02;

    Console.WriteLine("The sum of " + num01 + " and " + num02 + " is " + result + ".");
    
    Console.WriteLine();
    Thread.Sleep(2000);
    Console.WriteLine("The program will close in 5 seconds.");
    Thread.Sleep(5000);
    System.Environment.Exit(1);
}
if (op == "2")
{
    double num01;
    double num02;

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Enter your first number: ");
    num01 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter your second number");
    num02 = Convert.ToDouble(Console.ReadLine());

    double result = num01 - num02;

    Console.WriteLine("The difference between " + num01 + " and " + num02 + " is " + result + ".");
    
    Console.WriteLine();
    Thread.Sleep(2000);
    Console.WriteLine("The program will close in 5 seconds.");
    Thread.Sleep(5000);
    System.Environment.Exit(1);
}
if (op == "3")
{
    double num01;
    double num02;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Enter your first number");
    num01 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter your second number");
    num02 = Convert.ToDouble(Console.ReadLine());

    double result = num01 * num02;

    Console.WriteLine("The product of " + num01 + " and " + num02 + " is " + result + ".");
    Console.WriteLine();
    Thread.Sleep(2000);
    Console.WriteLine("The program will close in 5 seconds.");
    Thread.Sleep(5000);
    System.Environment.Exit(1);
}
if (op == "4")
{
    double num01;
    double num02;

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Enter your first number");
    num01 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter your second number");
    num02 = Convert.ToDouble(Console.ReadLine());

    double result = num01 / num02;
    
    Console.WriteLine("The quotient of " + num01 + " and " + num02 + " is " + result + ".");
    Console.WriteLine();
    Thread.Sleep(2000);
    Console.WriteLine("The program will close in 5 seconds.");
    Thread.Sleep(5000);
    System.Environment.Exit(1);
}
else


Console.ReadKey();