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
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial testimonial)
        {
            _testimonialDal.Add(testimonial);
        }

        public void Delete(Testimonial testimonial)
        {
            _testimonialDal.Delete(testimonial);
        }

        public Testimonial Get(Expression<Func<Testimonial, bool>> filter)
        {
            return _testimonialDal.Get(filter);
        }

        public List<Testimonial> GetAll(Expression<Func<Testimonial, bool>> filter = null)
        {
            return _testimonialDal.GetAll(filter);
        }

        public void Update(Testimonial testimonial)
        {
            _testimonialDal.Update(testimonial);
        }
    }
}
