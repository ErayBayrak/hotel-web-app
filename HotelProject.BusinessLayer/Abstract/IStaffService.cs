using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
   public interface IStaffService
    {
        void Add(Staff staff);
        void Delete(Staff staff);
        void Update(Staff staff);
        Staff Get(Expression<Func<Staff, bool>> filter);
        List<Staff> GetAll(Expression<Func<Staff, bool>> filter = null);
    }
}
