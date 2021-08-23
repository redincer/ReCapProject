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
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;
        public void Add(Color entity)
        {
            _colorDal.Add(entity);
        }

        public void Delete(Color entity)
        {
           _colorDal.Delete(entity);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll().ToList();
        }

        public List<Color> GetColorsByColordId(int colorId)
        {
            return _colorDal.GetAll(p => p.Id == colorId).ToList();
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }
    }
}
