using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.Interface
{
    public interface IContactRepository
    {
        IEnumerable<Person> GetContacts();
        Person GetContact(int id);
    }
}
