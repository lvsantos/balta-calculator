using Balta.Calculator.Application;

Console.Clear();
Console.WriteLine("Welcome to the Calculator!");
Console.WriteLine("--------------------------");
Console.WriteLine();

Console.WriteLine("Please, select an operation:");
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Divide");
Console.WriteLine("4 - Multiply");

bool isValid = false;
int option;
do
{
    Console.Write("Your option: ");
    isValid = int.TryParse(Console.ReadLine(), out option);
}while (!isValid);

Console.WriteLine();

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

switch (option)
{
    case 1:
        Console.WriteLine($"The sum of {num1} and {num2} is {Calculator.Add(num1, num2)}");
        break;
    case 2:
        Console.WriteLine($"The subtraction of {num1} and {num2} is {Calculator.Subtract(num1, num2)}");
        break;
    case 3:
        Console.WriteLine($"The division of {num1} and {num2} is {Calculator.Divide(num1, num2)}");
        break;
    /*case 4:
        Console.WriteLine($"The multiplication of {num1} and {num2} is {Calculator.Multiply(num1, num2)}");
        break;*/
    default:
        Console.WriteLine("Invalid option");
        break;
}