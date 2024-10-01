int bakiye = 10000;
Console.WriteLine("Bakiyeniz: " + bakiye);

Console.Write("Ne kadar çekmek istiyorsun? ");
int cekim = Convert.ToInt32(Console.ReadLine());

int sonuc = bakiye - cekim;
Console.WriteLine("Kalan Bakiye: " + sonuc);