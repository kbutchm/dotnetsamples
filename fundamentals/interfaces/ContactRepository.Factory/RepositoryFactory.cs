using Contact.Interface;
using ContactRepository.CVS;
using System;

namespace ContactRepository.Factory
{
    public class RepositoryFactory
    {
        public static IContactRepository GetRepository(string repotype)
        {

            IContactRepository repo = (repotype switch
            {
                "Service" => repo = new ContactRepository(),
                "CVS" => repo = new CVSRepository(),
                _ => throw new ArgumentException(message: "invalid selection", paramName: nameof(repotype))
            });

            return repo;
        }
    }
}
