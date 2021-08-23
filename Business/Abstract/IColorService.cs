using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetColorsByColordId(int colorId);
        void Add(Color entity);
        void Update(Color entity);
        void Delete(Color entity);
    }
}
