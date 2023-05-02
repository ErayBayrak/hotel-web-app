using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void Add(Subscribe subscribe)
        {
            _subscribeDal.Add(subscribe);
        }

        public void Delete(Subscribe subscribe)
        {
            _subscribeDal.Delete(subscribe);
        }

        public Subscribe Get(Expression<Func<Subscribe, bool>> filter)
        {
            return _subscribeDal.Get(filter);
        }

        public List<Subscribe> GetAll(Expression<Func<Subscribe, bool>> filter = null)
        {
            return _subscribeDal.GetAll(filter);
        }

        public void Update(Subscribe subscribe)
        {
            _subscribeDal.Update(subscribe);
        }
    }
}
