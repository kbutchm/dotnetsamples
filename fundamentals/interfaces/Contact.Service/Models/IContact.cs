using Contact.Interface;
using System.Collections.Generic;

namespace Contact.Service.Models
{
    public interface IContact
    {
        List<Person> GetContact();
    }
}
