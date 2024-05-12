// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your first number");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter your second number");
double num2 = double.Parse(Console.ReadLine()); 
double result = num1 - num2;
Console.WriteLine($"The value of {num1} - {num2} is {result}");