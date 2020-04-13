using System;
using System.Collections.Generic;

namespace Collections.Lists
{
    public class SampeLists
    {
        private List<string> GetColors()
        {
            List<string> colors = new List<string>
            {
                "Red", "Green", "Blue", "Black", "Purple", "Pink"
            };

            colors.Add("Orange");

            return colors;
        }

        public List<string> InsertColor(string color)
        {
            List<string> colors = GetColors();
            int findIndex = colors.FindIndex(x => x.Contains(color));
            colors.Insert(findIndex, "Indigio");

            return colors;
        }

        public List<string> RemoveColor(string color)
        {
            List<string> colors = GetColors();
            int findIndex = colors.FindIndex(x => x.Contains(color));
            colors.RemoveAt(findIndex);

            return colors;
        }
    }
}
