using Contact.Interface;
using System;
using System.Collections.Generic;

namespace ContactRepository.CVS
{
    public class CVSRepository : IContactRepository
    {
        public Person GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetContacts()
        {
            throw new NotImplementedException();
        }
    }
}
