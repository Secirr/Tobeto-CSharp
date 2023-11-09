using System;
namespace OOP1
{
	public class ProductManager
	{
		public void add(Product product)
		{

			Console.WriteLine("Ürün eklendi: " + product.ProductName);

		}
        public void update(Product product)
        {

			product.ProductName = "Tablet";
            Console.WriteLine("Ürün güncellendi: " + product.ProductName);

        }
    }
}

