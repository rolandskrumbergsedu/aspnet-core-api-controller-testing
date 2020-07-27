﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetApiControllers.Controllers
{
    public class PersonService : IPersonService
    {
        private List<Person> _allPeople = new List<Person>
        {
            new Person
            {
                Id = 1,
                Name = "Test"
            },
            new Person
            {
                Id = 2,
                Name = "Test 2"
            },
            new Person
            {
                Id = 3,
                Name = "Test 3"
            },
            new Person
            {
                Name = "tet",
                Id = 1
            }
        };

        public void AddPerson(Person person)
        {
            _allPeople.Add(person);
        }

        public Person DeletePersonById(int id)
        {
            var personToDelete = _allPeople.FirstOrDefault(x => x.Id == id);

            _allPeople.Remove(personToDelete);

            return personToDelete;
        }

        public List<Person> GetAllPeople()
        {
            return _allPeople;
        }

        public Person GetPersonById(int id)
        {
            var person = _allPeople.FirstOrDefault(x => x.Id == id);

            return person;
        }

        public Person UpdatePerson(Person person)
        {
            var personToUpdate = _allPeople.FirstOrDefault(x => x.Id == person.Id);

            if(personToUpdate == null)
            {
                return null;
            }

            personToUpdate.Name = person.Name;

            return personToUpdate;
        }
    }
}
