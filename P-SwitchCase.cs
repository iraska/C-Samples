// Patika - Switch case
// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;

// Expression
switch (month)
{
    case 1:
        Console.WriteLine("Ocak ayındasınız!");
        break;
    case 2:
        Console.WriteLine("Şubaty ayındasınız!");
        break;
    case 4:
        Console.WriteLine("Nisan ayındasınız!");
        break;
    case 3:
        Console.WriteLine("Mart ayındasınız!");
        break;
    case 5:
        Console.WriteLine("Mayıs ayındasınız!");
        break;
    default:
        Console.WriteLine("Yanlış veri girişi!");
        break;
}
