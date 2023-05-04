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
    public class BookingManager : IBookingService
    {
        private IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void Add(Booking booking)
        {
            _bookingDal.Add(booking);
        }

        public void Delete(Booking booking)
        {
            _bookingDal.Delete(booking);
        }

        public Booking Get(Expression<Func<Booking, bool>> filter)
        {
            return _bookingDal.Get(filter);
        }

        public List<Booking> GetAll(Expression<Func<Booking, bool>> filter = null)
        {
            return _bookingDal.GetAll(filter);
        }

        public void Update(Booking booking)
        {
            _bookingDal.Update(booking);
        }

        public void UpdateStatusOfBooking(int id)
        {
            _bookingDal.UpdateStatusOfBooking(id);
        }
    }
}
