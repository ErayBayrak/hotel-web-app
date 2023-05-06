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
    public class EfGuestDal : EFEntityRepositoryBase<Guest, Context>, IGuestDal
    {
        public int CountOfGuests()
        {
            using(Context context = new Context())
            {
                var values = (from x in context.Guests
                              select x.GuestId
                            ).Count();
                return values;
            }
        }
    }
}
