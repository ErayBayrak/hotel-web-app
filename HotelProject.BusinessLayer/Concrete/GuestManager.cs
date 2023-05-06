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
    public class GuestManager : IGuestService
    {
        private IGuestDal _guestDal;
        public GuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void Add(Guest guest)
        {
            _guestDal.Add(guest);
        }

        public int CountOfGuestNumber()
        {
            var values = _guestDal.CountOfGuests();
            return values;
        }

        public void Delete(Guest guest)
        {
            _guestDal.Delete(guest);
        }

        public Guest Get(Expression<Func<Guest, bool>> filter)
        {
            return _guestDal.Get(filter);
        }

        public List<Guest> GetAll(Expression<Func<Guest, bool>> filter)
        {
            return _guestDal.GetAll(filter);
        }

        public void Update(Guest guest)
        {
            _guestDal.Update(guest);
        }
    }
}
