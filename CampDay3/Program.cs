using CampDay3;

Urun urun1 = new Urun();
urun1.Id = 1;
urun1.Adi = "Muz";
urun1.Fiyat = 15;
urun1.Aciklama = "Hindistan Muzu";

Urun urun2 = new Urun();
urun2.Id = 2;
urun2.Adi = "Şeftali";
urun2.Fiyat = 20;
urun2.Aciklama = "Amasya Şeftalisi";

Urun urun3 = new Urun
{
    Id = 3,
    Adi = "Elma",
    Fiyat = 26,
    Aciklama = "Amasya Elması"
};

Urun[] uruns = new Urun[] {urun1,urun2,urun3};

foreach (var urun in uruns)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyat);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("------------");
}

Console.WriteLine("-----Metotlar-------");



SepetManager sepetManager = new SepetManager();

sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);
sepetManager.Ekle(urun3);


sepetManager.Ekle2("Elma", "Amasya Elması", 20,50);
sepetManager.Ekle2("karpuz", "Diyarbakır Karpuzu", 20,90);
sepetManager.Ekle2("cilek", "Edirne Çileği", 20,40);


Console.ReadKey();

