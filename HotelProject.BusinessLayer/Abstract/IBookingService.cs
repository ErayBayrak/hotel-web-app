using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookingService
    {
        void Add(Booking booking);
        void Delete(Booking booking);
        void Update(Booking booking);
        Booking Get(Expression<Func<Booking, bool>> filter);
        List<Booking> GetAll(Expression<Func<Booking, bool>> filter = null);
    }
}
