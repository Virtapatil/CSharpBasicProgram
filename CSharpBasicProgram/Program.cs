// See https://aka.ms/new-console-template for more information
using CSharpBasicProgram;
{
    Console.WriteLine("Welcome to CSharp basic programs");
    Console.WriteLine("Please enter first number");
    int first = Convert.ToInt32(Console.ReadLine());//10
    Console.WriteLine("Please enter second number");
    int second  = Convert.ToInt32(Console.ReadLine());

    Calculator calculator1 = new Calculator(first, second);
    calculator1.Addition();
    calculator1.Substraction();

    Console.WriteLine("Please enter first number");
    int third = Convert.ToInt32(Console.ReadLine());//10
    Console.WriteLine("Please enter second number");
    int forth = Convert.ToInt32(Console.ReadLine());
     
    Calculator calculator2 = new Calculator(third, forth);
    calculator2.Addition();
    calculator2.Substraction();
    Console.ReadLine();
}