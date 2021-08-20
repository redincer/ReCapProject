﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Text;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        /*
         * IEntityRepository'yi aynı fonksiyonları her Entity Dal için tekrardan yazmamak için oluşturduk.
         */
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
