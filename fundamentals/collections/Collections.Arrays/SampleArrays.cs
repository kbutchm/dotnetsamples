using System;

namespace Collections.Arrays
{
    public class SampleArrays
    {
        public string[] GetColors()
        {
            string[] colors = ColorsArray();

            return colors;
        }

        public string GetColor(int index)
        {
            string[] colors = ColorsArray();
            return colors[index];
        }

        public string UpdateColor(int index, string newColor)
        {
            string[] colors = ColorsArray();
            colors[index] = newColor;

            return colors[index];

        }

        private string[] ColorsArray()
        {
            string[] colors = { "Red", "Green", "Blue", "Black", "Purple", "Pink" };

            return colors;
        }
    }
}
