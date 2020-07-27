using Microsoft.AspNetCore.Mvc;

namespace AspNetApiControllers.Controllers
{
    public class PersonUiController : Controller
    {
        private IPersonService _personService;

        public PersonUiController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Index()
        {
            return View(_personService.GetAllPeople());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _personService.AddPerson(person);

            return View("Index");
        }
    }
}
