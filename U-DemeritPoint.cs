/ Udemy - Demerit point

// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
// Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. 
// If the user enters a value less than the speed limit, program should display Ok on the console. 
// If the value is above the speed limit, the program should calculate the number of demerit points. 
// For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
// If the number of demerit points is above 12, the program should display License Suspended.

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter the speed limit: ");
var speedLimit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the speed of your car? ");
var speed = Convert.ToInt32(Console.ReadLine());

if (speed < speedLimit)
    Console.WriteLine("Ok.");
else
{
    var demeritPoint = (speed - speedLimit) / 5;
    if (demeritPoint >= 12)
        Console.WriteLine("License suspended.");
        Console.WriteLine("Your demerit point is: " + demeritPoint);
}
