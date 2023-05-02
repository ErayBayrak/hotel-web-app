using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelServicesController : ControllerBase
    {
        IHotelServiceService _hotelServiceService;

        public HotelServicesController(IHotelServiceService hotelServiceService)
        {
            _hotelServiceService = hotelServiceService;
        }

        [HttpGet]
        public IActionResult HotelServiceList()
        {
            var hotelServices = _hotelServiceService.GetAll();
            return Ok(hotelServices);
        }
        [HttpPost]
        public IActionResult AddHotelService(HotelService hotelService)
        {
            _hotelServiceService.Add(hotelService);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteHotelService(int id)
        {
            var deletedValue = _hotelServiceService.Get(x => x.HotelServiceId == id);
            _hotelServiceService.Delete(deletedValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateHotelService(HotelService hotelService)
        {
            _hotelServiceService.Update(hotelService);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetHotelService(int id)
        {
            var value = _hotelServiceService.Get(x => x.HotelServiceId == id);
            return Ok(value);
        }
    }
}
