﻿using System;
using Business.Abstract;
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
                return new ErrorResult("Ürün ismi en az 2 karakter olmalıdır.");
            }
            _productDal.Add(product);

            return new SuccesResult("Ürün eklendi.");
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
