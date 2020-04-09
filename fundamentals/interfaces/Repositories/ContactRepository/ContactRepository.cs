using Contact.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace ContactRepository
{
    public class ContactRepository : IContactRepository
    {
        WebClient client = new WebClient();
        string baseUri = "http://localhost:54905/api/contact";

        public Person GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetContacts()
        {
            string list = client.DownloadString(baseUri);
            return JsonConvert.DeserializeObject<IEnumerable<Person>>(list);
        }
    }
}
