﻿using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.About;
using HotelProject.WebUI.DTOs.Booking;
using HotelProject.WebUI.DTOs.HotelService;
using HotelProject.WebUI.DTOs.Login;
using HotelProject.WebUI.DTOs.Register;
using HotelProject.WebUI.DTOs.Room;
using HotelProject.WebUI.DTOs.Staff;
using HotelProject.WebUI.DTOs.Subscribe;
using HotelProject.WebUI.DTOs.Testimonial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateHotelServiceDto, HotelService>().ReverseMap();
            CreateMap<UpdateHotelServiceDto, HotelService>().ReverseMap();
            CreateMap<ResultHotelServiceDto, HotelService>().ReverseMap();

            CreateMap<CreateRegisterDto, AppUser>().ReverseMap();
            CreateMap<LoginDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultRoomDto, Room>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<BookingConfirmDto, Booking>().ReverseMap();
        }
    }
}
