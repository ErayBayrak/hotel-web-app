using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IHotelServiceService
    {
        void Add(HotelService hotelService);
        void Delete(HotelService hotelService);
        void Update(HotelService hotelService);
        HotelService Get(Expression<Func<HotelService, bool>> filter);
        List<HotelService> GetAll(Expression<Func<HotelService, bool>> filter = null);
    }
}
