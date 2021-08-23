using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetBrandsByBrandId(int brandId);
        void Add(Brand entity);
        void Update(Brand entity);
        void Delete(Brand entity);
    }
}
