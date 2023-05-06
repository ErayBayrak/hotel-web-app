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
    public class EfStaffDal : EFEntityRepositoryBase<Staff, Context>, IStaffDal
    {
        public int CountOfStaffs()
        {
            using (Context context = new Context())
            {
                var values = (from x in context.Staffs
                              select x.StaffId
                              ).Count();
                return values;
            }
            
        }
    }
}
