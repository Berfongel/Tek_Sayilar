// See https://aka.ms/new-console-template for more information
int sayi;
//1 den 100 e kadar olan 
for (sayi=1;sayi<=100;sayi++) 
{
    //2 ile tam bölünmüyorsa sayı tek sayıdır.
    if (sayi % 2 != 0)
    {
        Console.WriteLine("Tek sayılar : " + sayi);
        sayi++;
    }
}
Console.ReadKey();
