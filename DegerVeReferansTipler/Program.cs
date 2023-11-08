

int sayi1 = 40;
int sayi2 = 50;
sayi1 = sayi2;
sayi2 = 65;
//sayi1 ?? 50

Console.WriteLine(sayi1);


int[] sayilar1 = new int[] { 40, 50, 10 };
int[] sayilar2 = new int[] { 92, 54, 875 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1[0] 999

Console.WriteLine(sayilar2[0]);

Console.ReadKey();