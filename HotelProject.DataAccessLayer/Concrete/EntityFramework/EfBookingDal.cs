using HotelProject.CoreLayer.DataAccess.EntityFramework;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfBookingDal : EFEntityRepositoryBase<Booking, Context>, IBookingDal
    {
        public void UpdateStatusOfBooking(int id)
        {
            Context context = new Context();
            var result = context.Bookings.Where(x => x.BookingId == id).FirstOrDefault();
            result.Status = "Onaylandı";
            context.SaveChanges();
        }
    }
}
