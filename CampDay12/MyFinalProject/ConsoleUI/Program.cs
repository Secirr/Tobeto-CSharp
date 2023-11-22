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

    var result = productManager.GetProductDetails();

    if (result.Succes == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
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