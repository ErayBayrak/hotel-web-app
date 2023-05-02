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
    public class HotelServiceManager : IHotelServiceService
    {
        IHotelServiceDal _hotelServiceDal;

        public HotelServiceManager(IHotelServiceDal hotelServiceDal)
        {
            _hotelServiceDal = hotelServiceDal;
        }

        public void Add(HotelService hotelService)
        {
            _hotelServiceDal.Add(hotelService);
        }

        public void Delete(HotelService hotelService)
        {
            _hotelServiceDal.Delete(hotelService);
        }

        public HotelService Get(Expression<Func<HotelService, bool>> filter)
        {
            return _hotelServiceDal.Get(filter);
        }

        public List<HotelService> GetAll(Expression<Func<HotelService, bool>> filter = null)
        {
            return _hotelServiceDal.GetAll(filter);
        }

        public void Update(HotelService hotelService)
        {
            _hotelServiceDal.Update(hotelService);
        }
    }
}
