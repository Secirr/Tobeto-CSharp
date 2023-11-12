

using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.Id = 1;
musteri1.MusteriNo = "14135315";
musteri1.Adi = "Kadir";
musteri1.SoyAdi = "Özdemir";
musteri1.TcNo = "231424234";


TuzelMusteri tuzelMusteri = new TuzelMusteri();
tuzelMusteri.Id = 2;
tuzelMusteri.MusteriNo = "324325235";
tuzelMusteri.SirketAdi = "Courself";
tuzelMusteri.VergiNo = "315315325";

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);
musteriManager.Ekle(musteri3);
musteriManager.Ekle(musteri4);

Console.ReadKey();
