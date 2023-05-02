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
    public class RoomsController : ControllerBase
    {
        [HttpGet]
        public IActionResult RoomList()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(Room room)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            return Ok();
        }
    }
}
