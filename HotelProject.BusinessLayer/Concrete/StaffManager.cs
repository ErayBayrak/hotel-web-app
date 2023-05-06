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
    public class StaffManager : IStaffService
    {
        IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Add(Staff staff)
        {
            _staffDal.Add(staff);
        }

        public int CountOfStaffNumber()
        {
            var values = _staffDal.CountOfStaffs();
            return values;
        }

        public void Delete(Staff staff)
        {
            _staffDal.Delete(staff);
        }

        public Staff Get(Expression<Func<Staff, bool>> filter)
        {
            return _staffDal.Get(filter);
        }

        public List<Staff> GetAll(Expression<Func<Staff, bool>> filter = null)
        {
            return _staffDal.GetAll(filter);
        }

        public void Update(Staff staff)
        {
            _staffDal.Update(staff);
        }
    }
}
