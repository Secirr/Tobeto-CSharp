﻿using System;
using System.Linq.Expressions;
using Core.Entitites;

namespace Core.DataAccess
{
    //Generic constraint(kısıt)
    //Class : Referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı


	public interface IEntityRepository<T> where T:class,IEntity,new()
	{
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}

