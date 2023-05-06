using Autofac;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelProject.BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           
            builder.RegisterType<HotelServiceManager>().As<IHotelServiceService>().SingleInstance();
            builder.RegisterType<EfHotelServiceDal>().As<IHotelServiceDal>().SingleInstance();

            builder.RegisterType<RoomManager>().As<IRoomService>().SingleInstance();
            builder.RegisterType<EfRoomDal>().As<IRoomDal>().SingleInstance();

            builder.RegisterType<StaffManager>().As<IStaffService>().SingleInstance();
            builder.RegisterType<EfStaffDal>().As<IStaffDal>().SingleInstance();

            builder.RegisterType<SubscribeManager>().As<ISubscribeService>().SingleInstance();
            builder.RegisterType<EfSubscribeDal>().As<ISubscribeDal>().SingleInstance();

            builder.RegisterType<TestimonialManager>().As<ITestimonialService>().SingleInstance();
            builder.RegisterType<EfTestimonialDal>().As<ITestimonialDal>().SingleInstance();

            builder.RegisterType<AboutManager>().As<IAboutService>().SingleInstance();
            builder.RegisterType<EfAboutDal>().As<IAboutDal>().SingleInstance();

            builder.RegisterType<BookingManager>().As<IBookingService>().SingleInstance();
            builder.RegisterType<EfBookingDal>().As<IBookingDal>().SingleInstance();

            builder.RegisterType<GuestManager>().As<IGuestService>().SingleInstance();
            builder.RegisterType<EfGuestDal>().As<IGuestDal>().SingleInstance();

        }
    }
}
