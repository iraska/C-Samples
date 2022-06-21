// Udemy - Foreach max
// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. 
// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a series of numbers separated by comma: ");

var numbers = Console.ReadLine().Split(',');  //split() belirtilen karakterler çıkartılarak string array oluşur.
var max = 0;

foreach (var number in numbers)
{
    var numb = Convert.ToInt32(number);

    if (numb > max)
    {
        max = numb;
    }
}
Console.WriteLine("max = " + max);
