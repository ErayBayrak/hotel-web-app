using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface ITestimonialService
    {
        void Add(Testimonial testimonial);
        void Delete(Testimonial testimonial);
        void Update(Testimonial testimonial);
        Testimonial Get(Expression<Func<Testimonial, bool>> filter);
        List<Testimonial> GetAll(Expression<Func<Testimonial, bool>> filter = null);
    }
}
