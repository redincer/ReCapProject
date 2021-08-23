using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public void Delete(Brand entity)
        {
           _brandDal.Delete(entity);
        }


        public List<Brand> GetAll()
        {
            return _brandDal.GetAll().ToList();
        }

        

        public List<Brand> GetBrandsByBrandId(int brandId)
        {
            return _brandDal.GetAll(p => p.Id == brandId).ToList();
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
