// Patika - TryCatcFinally
// See https://aka.ms/new-console-template for more information
try
{
    Console.WriteLine("Bir sayi giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmis oldugunuz sayi:" + sayi);    
}
catch(Exception ex)
{
    Console.WriteLine("Hata:" + ex.Message.ToString());
}
finally
{
    Console.WriteLine("İslem Tamamlandi.");
}

// User Friendly - Exception
try
{
    // int a = int.Parse(null);
    // int a = int.Parse("test");
    int a = int.Parse("-20000000000");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine("ex");
    throw;
}
catch (FormatException ex)
{
    Console.WriteLine("Veri tipi uygun değil.");
    Console.WriteLine("ex");
    throw;
}
catch (OverflowException ex)
{
    Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
    Console.WriteLine("ex");
    throw;
}
finally
{
    Console.WriteLine("İşlem başarıyla tamamlandı.");
}
