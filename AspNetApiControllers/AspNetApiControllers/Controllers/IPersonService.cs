using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspNetApiControllers.Controllers
{
    public interface IPersonService
    {
        List<Person> GetAllPeople();
        Person GetPersonById(int id);
        void AddPerson(Person person);
        Person UpdatePerson(Person person);
        Person DeletePersonById(int id);
    }
}