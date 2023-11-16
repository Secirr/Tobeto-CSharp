using System;
using System.Linq.Expressions;
using Core.Entitites;
using Microsoft.EntityFrameworkCore;


namespace Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); //referans yakalama
                addedEntity.State = EntityState.Added; //eklenecek bir nesne
                context.SaveChanges(); //ekle
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //referans yakalama
                deletedEntity.State = EntityState.Deleted; //Silinecek bir nesne
                context.SaveChanges(); //sil
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter); //filtreyi uygula
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null) //landa yapısı
        {
            using (TContext context = new TContext())
            {
                return filter == null  //filtre null mı?
                    ? context.Set<TEntity>().ToList() //Null ise product'ı listeye çevir
                    : context.Set<TEntity>().Where(filter).ToList(); //filtre null yani filtre varsa
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //referans yakalama
                updatedEntity.State = EntityState.Modified; //güncellenecek bir nesne
                context.SaveChanges(); //güncelle
            }
        }

    }

}

