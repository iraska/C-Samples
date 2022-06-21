// Udemy - Random flag
// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
// If the user guesses the number, display “You won"; otherwise, display “You lost". 
// (To make sure the program is behaving correctly, you can display the secret number on the console first.)

// See https://aka.ms/new-console-template for more information

var random = new Random();
var randomNumber = random.Next(1, 10); //for içinde tanımlarsak döngü sonunda yeni random atanır.

var flag = false; //kullanıcının kazanma durumu (henüz kazanmadı, false)

Console.WriteLine("Hi! Please enter a number between 1 and 10, you have four chances: ");

for (int i = 0; i < 4; i++)
{
    var number = Convert.ToInt32(Console.ReadLine().Trim());

    if (randomNumber == number)
    {
        flag = true;
        Console.WriteLine("You won!");
        break;
    }
}
if (flag == false)
    Console.WriteLine("You lost!");

Console.WriteLine(randomNumber);
