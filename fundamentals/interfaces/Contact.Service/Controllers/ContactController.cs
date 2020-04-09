using Contact.Interface;
using Contact.Service.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Contact.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContact _contact;

        public ContactController(IContact contact)
        {
            _contact = contact;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _contact.GetContact();
        }

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _contact.GetContact().FirstOrDefault(p => p.Id == id);
        }
    }
}