

using GenericsIntro;



MyList<string> isimler = new MyList<string>();
isimler.Add("Kadir");

Console.WriteLine(isimler.length);

isimler.Add("Atakan");

Console.WriteLine(isimler.length);

foreach (var isim in isimler.Items)
{
    Console.WriteLine(isim);
}

Console.ReadKey();