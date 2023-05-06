using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
   public interface IRoomService
    {
        void Add(Room room);
        void Delete(Room room);
        void Update(Room room);
        Room Get(Expression<Func<Room, bool>> filter);
        List<Room> GetAll(Expression<Func<Room, bool>> filter = null);
        int CountOfRoomNumber();
    }
}
