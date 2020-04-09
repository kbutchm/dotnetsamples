using Contact.Interface;
using System.Collections.Generic;

namespace Contact.Service.Models
{
    public class Contacts : IContact
    {
        public List<Person> GetContact()
        {
            var contact = new List<Person>()
            {
                new Person() { Id = 1, FirstName = "John", LastName = "Upster", Email = "john@gmail.com" },
                new Person() { Id = 2, FirstName = "Sean", LastName = "Chrome", Email = "sean@yahoo.com" },
                new Person() { Id = 3, FirstName = "Diane", LastName = "Letter", Email = "diane@hotmail.com" },
                new Person() { Id = 4, FirstName = "Jane", LastName = "Jimney", Email = "jane24@gmail.com" }
            };

            return contact;
        }
    }
}
