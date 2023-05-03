using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IAboutService
    {
        void Add(About about);
        void Delete(About about);
        void Update(About about);
        About Get(Expression<Func<About, bool>> filter);
        List<About> GetAll(Expression<Func<About, bool>> filter=null);
    }
}
