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
    public class ContactController : ControllerBase
    {
       private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var contacts = _contactService.GetAll();
            return Ok(contacts);
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _contactService.Add(contact);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var deletedValue = _contactService.Get(x => x.ContactId == id);
            _contactService.Delete(deletedValue);
            return Ok();
        }
        [HttpPut("UpdateContact")]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactService.Update(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.Get(x => x.ContactId == id);
            return Ok(value);
        }
    }
}
