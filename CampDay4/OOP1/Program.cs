
using System.Collections.Generic;
using OOP1;


//Nesne Tabanlı Programlama

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 1;
product1.ProductName = "Televizyon";
product1.UnitPrice = 15000;
product1.UnitsInStock = 13;

Product product2 = new Product()
{
    Id = 2,
    CategoryId = 2,
    ProductName = "Telefon",
    UnitPrice = 32000,
    UnitsInStock=5
};

//Değer Ve Referans Tipler

ProductManager productManager = new ProductManager();
productManager.add(product1);
productManager.update(product1);
Console.WriteLine(product1.ProductName);


Console.WriteLine("---------Koleksiyonlar---------");

//koleksiyonlar

//diziler
string[] isimler = new String[] { "Kadir", "Özdemir", "Atilla", "Mina" };
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);

isimler = new String[5];
isimler[4] = "Atakan";
Console.WriteLine(isimler[4]);
Console.WriteLine(isimler[0]);

Console.WriteLine("---------Listeler---------");

//listeler

List<string> isimler2 = new List<string> { "Kadir", "Özdemir", "Atilla", "Mina" };
Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);
isimler2.Add("Atakan");
Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);



Console.ReadKey();