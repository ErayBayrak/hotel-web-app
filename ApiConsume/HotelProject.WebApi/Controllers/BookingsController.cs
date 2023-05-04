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
    public class BookingsController : ControllerBase
    {
        IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var bookings = _bookingService.GetAll();
            return Ok(bookings);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.Add(booking);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var deletedValue = _bookingService.Get(x => x.BookingId == id);
            _bookingService.Delete(deletedValue);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.Update(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.Get(x => x.BookingId == id);
            return Ok(value);
        }
        [HttpPut("BookingUpdateStatus")]
        public IActionResult BookingUpdateStatus(int id)
        {
            _bookingService.UpdateStatusOfBooking(id);
            return Ok();
        }
    }
}
