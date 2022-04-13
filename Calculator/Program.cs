using Calculator;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var calc = new Calculator.Calculator();


Console.WriteLine("enter number A");
string num1;
double numA;
bool isDouble1;


do
{
    num1 = Console.ReadLine();

    isDouble1 = double.TryParse(num1, out numA);

    if (!isDouble1)
    {
        Console.WriteLine("Not valid input. Try Again:");
    }
} while (!isDouble1);


string num2;
double numB;
bool isDouble2;


Console.WriteLine("enter number B");



do
{
    num2 = Console.ReadLine();

    isDouble2 = double.TryParse(num2, out numB);

    if (!isDouble2)
    {
        Console.WriteLine("Not valid input. Try Again:");
    }
} while (!isDouble2);



var result = calc.Add(numA, numB);

Console.WriteLine($"Result is {result}");
Console.ReadLine();
