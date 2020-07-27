using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetApiControllers.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class PersonController : ControllerBase
    {
        

        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return _personService.GetAllPeople();
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var person = _personService.GetPersonById(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        [HttpPost]
        public ActionResult<Person> Add(Person person)
        {
            _personService.AddPerson(person);

            return person;
        }

        [HttpPut]
        public ActionResult<Person> Update(Person person)
        {
            var personUpdated = _personService.UpdatePerson(person);

            if (personUpdated == null)
            {
                return BadRequest();
            }

            return personUpdated;
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var personDeleted = _personService.DeletePersonById(id);

            if (personDeleted == null)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
