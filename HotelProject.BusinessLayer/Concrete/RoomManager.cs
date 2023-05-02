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
    public class RoomManager : IRoomService
    {
        IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void Add(Room room)
        {
            _roomDal.Add(room);
        }

        public void Delete(Room room)
        {
            _roomDal.Delete(room);
        }

        public Room Get(Expression<Func<Room, bool>> filter)
        {
            return _roomDal.Get(filter);
        }

        public List<Room> GetAll(Expression<Func<Room, bool>> filter = null)
        {
            return _roomDal.GetAll(filter);
        }

        public void Update(Room room)
        {
            _roomDal.Update(room);
        }
    }
}
