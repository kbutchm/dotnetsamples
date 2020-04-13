using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Contact.Interface;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using ContactRepository.Factory;

namespace ContactRepository.Tests
{
    [TestClass()]
    public class ContactRepositoryTests
    {

        private IEnumerable<Person> GetContact()
        {
            var contact = new List<Person>()
            {
                new Person() { Id = 1, FirstName = "John", LastName = "Upster", Email = "john@gmail.com",  },
                new Person() { Id = 2, FirstName = "Sean", LastName = "Chrome", Email = "sean@yahoo.com" },
                new Person() { Id = 3, FirstName = "Diane", LastName = "Letter", Email = "diane@hotmail.com" },
                new Person() { Id = 4, FirstName = "Jane", LastName = "Jimney", Email = "jane24@gmail.com" }
            };

            return contact;
        }

        [TestMethod()]
        public void GetContactsTest()
        {
            // arrange
            // call factory method
            var repository = RepositoryFactory.GetRepository("Service");         

            var expected = GetContact();

            // act
            var actual = repository.GetContacts();
            
            // assert
            Assert.IsTrue(expected.SequenceEqual(actual, new PersonEqualityComparer()));
        }

        [TestMethod]
        public void GetContactsCVSTest()
        {
            // arrange
            var repository = RepositoryFactory.GetRepository("CVS");
            var expected = GetContact();

            // act
            var actual = repository.GetContacts();

            // assert
            Assert.IsTrue(expected.SequenceEqual(actual, new PersonEqualityComparer()));

        }
    }

    public class PersonEqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals([AllowNull] Person x, [AllowNull] Person y)
        {
            if (object.ReferenceEquals(x, y)) return true;

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null)) return false;

            return x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            if (object.ReferenceEquals(obj, null)) return 0;

            int hashCodeFirstName = obj.FirstName == null ? 0 : obj.FirstName.GetHashCode();

            int hashCodeLastName = obj.LastName == null ? 0 : obj.LastName.GetHashCode();


            return hashCodeFirstName ^ hashCodeLastName;

        }
    }
}