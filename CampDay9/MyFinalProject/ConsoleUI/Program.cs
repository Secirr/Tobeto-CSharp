using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//S O LID
//Open Closed Principle

//CategoryTest();
ProductTest();

Console.ReadKey();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
    }
}

static void CategoryTest()
{
    EfCategoryDal efCategoryDal = new EfCategoryDal();
    CategoryManager categoryManager = new CategoryManager(efCategoryDal);
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}