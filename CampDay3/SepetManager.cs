using System;
namespace CampDay3
{
	public class SepetManager
	{
		public void Ekle(Urun urun)
		{
			Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi);
		}

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi);
        }
    }
}

