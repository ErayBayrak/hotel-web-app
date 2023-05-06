using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete.EntityFramework;
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
    public class GuestsController : ControllerBase
    {
        IGuestService _guestService;

        public GuestsController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult GuestList()
        {
            var guests = _guestService.GetAll();
            return Ok(guests);
        }
        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.Add(guest);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteGuest(int id)
        {
            var deletedValue = _guestService.Get(x => x.GuestId == id);
            _guestService.Delete(deletedValue);
            return Ok();
        }
        [HttpPut("UpdateGuest")]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.Update(guest);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetGuest(int id)
        {
            var value = _guestService.Get(x => x.GuestId == id);
            return Ok(value);
        }
     
        [HttpGet("countGuest")]
        public IActionResult CountOfGuests()
        {
            var value = _guestService.CountOfGuestNumber();
            return Ok(value);
        }
    }
}
