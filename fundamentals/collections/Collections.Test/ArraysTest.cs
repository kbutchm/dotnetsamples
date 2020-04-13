using Collections.Arrays;
using NUnit.Framework;

namespace Collections.Test
{
    public class ArraysTest
    {
        SampleArrays arraySamples;
        string[] expected = null;

        [SetUp]
        public void Setup()
        {
            expected =  new string[] { "Red", "Green", "Blue", "Black", "Purple", "Pink" };
            arraySamples = new SampleArrays();

        }

        [Test]
        public void GetColorsTest()
        {
            // arrange
            // act
            string[] actual = arraySamples.GetColors();

            // assert
            Assert.AreEqual(expected.Length, actual.Length);
        }

        [Test]
        public void GetColorTest()
        {
            // arrange
            // act 
            string actual = arraySamples.GetColor(1);

            // assert
            Assert.AreEqual(expected[1], actual);

        }

        [Test]
        public void UpdateColorTest()
        {
            // act
            string actual = arraySamples.UpdateColor(5, "Orange");

            // assert
            Assert.AreEqual("Orange", actual);
        }
    }
}