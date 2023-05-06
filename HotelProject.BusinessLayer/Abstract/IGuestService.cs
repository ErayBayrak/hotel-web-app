using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
   public interface IGuestService
    {
        void Add(Guest guest);
        void Delete(Guest guest);
        void Update(Guest guest);
        Guest Get(Expression<Func<Guest, bool>> filter);
        List<Guest> GetAll(Expression<Func<Guest, bool>> filter=null);
        int CountOfGuestNumber();
    }
}
