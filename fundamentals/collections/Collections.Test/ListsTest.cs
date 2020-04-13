using System;
using System.Collections.Generic;
using System.Text;
using Collections.Lists;
using NUnit.Framework;

namespace Collections.Test
{
    public class ListsTest
    {
        SampeLists sampleList;
        List<string> expected;

        [SetUp]
        public void Setup()
        {
            sampleList = new SampeLists();
            expected = new List<string>
            {
                "Red", "Green", "Blue", "Black", "Purple", "Pink", "Orange"
            };
        }

        [Test]
        public void InsertColorTest()
        {
            // act
            var actual = sampleList.InsertColor("Black");

            // assert
            Assert.AreEqual(expected.Count + 1, actual.Count);
        }

        [Test]
        public void RemoveColorTest()
        {
            // act
            var actual = sampleList.RemoveColor("Black");

            // assert
            Assert.AreEqual(expected.Count - 1, actual.Count);
        }
    }
}
