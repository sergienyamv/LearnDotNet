using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Linq;

namespace Sorting
{
    public class SortTests
    {
        static Random _random = new Random();

        static TestData[] TestContext =
            Enumerable.Repeat(0, 10).Select(i => TestData.Create(1000000)).ToArray();


        [Test, TestCaseSource("TestContext")]
        public void OrderByTest(TestData context)
        {
            var watch = Stopwatch.StartNew();
            var sorted = context.UnsortedArray.OrderBy(i => i);
            watch.Stop();

            Assert.AreEqual(context.SortedArray, sorted);
            Console.WriteLine($"Sorting time: {watch.ElapsedMilliseconds} ms");
        }

        [Test, TestCaseSource("TestContext")]
        public void QuickSortTest(TestData context)
        {
            var watch = Stopwatch.StartNew();
            var sorted = QuickSortHelper.Sort(context.UnsortedArray, 0, context.UnsortedArray.Length - 1);
            watch.Stop();

            Assert.AreEqual(context.SortedArray, sorted);
            Console.WriteLine($"Sorting time: {watch.ElapsedMilliseconds} ms");
        }

        [Test, TestCaseSource("TestContext")]
        public void MergeSortTest(TestData context)
        {
            var watch = Stopwatch.StartNew();
            var sorted = MergeSortHelper.Sort(context.UnsortedArray);
            watch.Stop();

            Assert.AreEqual(context.SortedArray, sorted);
            Console.WriteLine($"Sorting time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
