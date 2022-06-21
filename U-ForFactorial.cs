// Udemy - For loop / factorial
// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a number: ");
var number = Convert.ToInt32(Console.ReadLine().Trim());
var output = 1;
for (var i = 1; i <= number; i++)
{
    output *= i;
}
Console.WriteLine(number + "! = " + output); //döngü number kadar dönüyor.
