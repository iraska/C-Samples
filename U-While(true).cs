// Udemy - While Loop
// Write a program and continuously ask the user to enter a number or "ok" to exit. 
// Calculate the sum of all the previously entered numbers and display it on the console.

// See https://aka.ms/new-console-template for more information
var total = 0;
while (true)
{
    Console.Write("Please enter a number or 'ok' to exit: ");
    var input = Console.ReadLine();
    var ok = "ok";
    if (input == ok)
        break;
    else
    {
        var number = Convert.ToInt32(input);
        total += number; //total = total + number;
        Console.WriteLine(total);
    }
}
