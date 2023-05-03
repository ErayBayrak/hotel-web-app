using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.DTOs.HotelService;
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
        }
    }
}
