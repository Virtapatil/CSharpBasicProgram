// See https://aka.ms/new-console-template for more information
using CSharpBasicProgram;
{
    Console.WriteLine("Welcome to CSharp basic programs");
    Console.WriteLine("Please enter first number");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter second number");
    int second  = Convert.ToInt32(Console.ReadLine());

    Calculator calculator = new Calculator(first, second);
    calculator.Addition();
    Console.ReadLine();
}