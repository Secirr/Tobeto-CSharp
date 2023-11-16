using System;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;

using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet

    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //referans yakalama
                addedEntity.State = EntityState.Added; //eklenecek bir nesne
                context.SaveChanges(); //ekle
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); //referans yakalama
                deletedEntity.State = EntityState.Deleted; //Silinecek bir nesne
                context.SaveChanges(); //sil
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); //filtreyi uygula
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null) //landa yapısı
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null  //filtre null mı?
                    ? context.Set<Product>().ToList() //Null ise product'ı listeye çevir
                    : context.Set<Product>().Where(filter).ToList(); //filtre null yani filtre varsa
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); //referans yakalama
                updatedEntity.State = EntityState.Modified; //güncellenecek bir nesne
                context.SaveChanges(); //güncelle
            }
        }
    }
}

