using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public class TestData
    {
        private static readonly Random _random = new Random();

        private TestData() { }

        public int[] SortedArray { get; private set; }
        public int[] UnsortedArray { get; private set; }

        public static TestData Create(int count)
        {
            var data = new TestData();
            var basis = int.MaxValue / (count + 1);
            var uns = new List<int>();
            for (int i = 0; i < count; i++)
            {
                uns.Add(_random.Next());
            }
            data.UnsortedArray = uns.ToArray();

            data.SortedArray = uns.OrderBy(i => i).ToArray();

            return data;
        }
    }
}
