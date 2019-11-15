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
            var sorted = new List<int>();
            for (int i = 0; i < count; i++)
            {
                sorted.Add(_random.Next(basis) + basis * i);
            }
            data.SortedArray = sorted.ToArray();

            var unsorted = new List<int>();

            while(sorted.Any())
            {
                var i = _random.Next(sorted.Count);
                unsorted.Add(sorted[i]);
                sorted.RemoveAt(i);
            }
            data.UnsortedArray = unsorted.ToArray();

            return data;
        }
    }
}
