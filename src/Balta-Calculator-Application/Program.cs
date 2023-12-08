using Balta.Calculator.Application;

Console.Clear();
Console.WriteLine("Welcome to the Calculator!");
Console.WriteLine("--------------------------");
Console.WriteLine();

bool isValid = false;
double num1, num2;
do
{
    Console.Write("Please enter the first number:");
    isValid = double.TryParse(Console.ReadLine(), out num1);
} while (!isValid);

do
{
    Console.Write("Please enter the second number:");
    isValid = double.TryParse(Console.ReadLine(), out num2);
} while (!isValid);

Console.WriteLine();
Console.WriteLine($"The sum of {num1} and {num2} is {Calculator.Add(num1, num2)}");
