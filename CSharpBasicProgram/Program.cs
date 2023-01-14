// See https://aka.ms/new-console-template for more information
using CSharpBasicProgram;
using System.ComponentModel;

Console.WriteLine("Hello, good morning ");
Console.WriteLine("Enter day number");
int day = Convert.ToInt32(Console.ReadLine());
Weekday.FindWeekDay(day);
