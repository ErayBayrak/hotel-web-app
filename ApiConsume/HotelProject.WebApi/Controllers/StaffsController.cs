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
    public class StaffsController : ControllerBase
    {
        IStaffService _staffService;

        public StaffsController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var staffs = _staffService.GetAll();
            return Ok(staffs);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.Add(staff);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var deletedValue = _staffService.Get(x => x.StaffId == id);
            _staffService.Delete(deletedValue);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        {
            _staffService.Update(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var value = _staffService.Get(x => x.StaffId == id);
            return Ok(value);
        }
        [HttpGet("staffcount")]
        public IActionResult GetCountOfStaff()
        {
            var values = _staffService.CountOfStaffNumber();
            return Ok(values);
        }
    }
}
