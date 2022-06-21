// Udemy - For loop
// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.

See https://aka.ms/new-console-template for more information
var counter = 0;

for (var i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
        counter++;
}
Console.WriteLine(counter);
