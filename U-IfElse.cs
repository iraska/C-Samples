// Write a program and ask the user to enter a number. 
// The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
// Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

// Udemy - if else

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a number: ");

int number = Convert.ToInt32(Console.ReadLine().Trim());

if (number > 1 && number < 10)
    Console.WriteLine("Valid!");
else
    Console.WriteLine("Unvalid!");
