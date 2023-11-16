using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }



        public IResult Add(Product product)
        {
            //bussines codes


            if (product.ProductName.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);

            return new SuccesResult(Messages.ProductAdded);
        }

        public List<Product> GetAll()
        {
            //İş Kodları
            //Örnek: Yetkisi var mı?
            //Kurallar ! ! !
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id); //landa yapısı
        }

        public Product GetById(int ProductId)
        {
            return _productDal.Get(p=>p.ProductId == ProductId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}

