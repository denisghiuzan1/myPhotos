using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotos.Model;

namespace MyPhotosUI.Controllers
{
    public class PersonsController
    {
        private readonly List<Person> persons = new List<Person>
        {
            new Person
            {
                FirstName = "Bob",
                LastName = "Dylan"
            }
        };

        public List<Person> GetAllPersons()
        {
            return this.persons;
        }
    }
}
