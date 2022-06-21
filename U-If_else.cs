// Udemy - If else 
// Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter the width of an image: ");
float width = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Please enter the height of an image: ");
float height = Convert.ToSingle(Console.ReadLine());

if (width > height)
    Console.WriteLine("It's landscape.");
else
    Console.WriteLine("It's portrait.");
