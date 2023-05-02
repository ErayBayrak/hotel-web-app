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
    public class StaffsController : ControllerBase
    {
        [HttpGet]
        public IActionResult StaffList()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff(Staff staff)
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            return Ok();
        }
    }
}
