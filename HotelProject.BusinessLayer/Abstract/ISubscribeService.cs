using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface ISubscribeService
    {
        void Add(Subscribe subscribe);
        void Delete(Subscribe subscribe);
        void Update(Subscribe subscribe);
        Subscribe Get(Expression<Func<Subscribe, bool>> filter);
        List<Subscribe> GetAll(Expression<Func<Subscribe, bool>> filter = null);
    }
}
