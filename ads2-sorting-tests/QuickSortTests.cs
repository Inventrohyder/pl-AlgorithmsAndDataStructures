using System;
using ads2_sorting;
using Xunit;

namespace ads2_sorting_tests
{
    public class QuickSortTests
    {
        BaseSortTests<QuickSort<int>> test = new BaseSortTests<QuickSort<int>>();
        QuickSort<int> sorter = new QuickSort<int>();

        [Fact]
        public void PreSortedTests()
        {
            test.PreSortedTests(sorter);
        }

        [Fact]
        public void UnsortedTests()
        {
            test.UnsortedTests(sorter);
        }

        [Fact]
        public void RandomTests()
        {
            test.RandomTests(sorter);
        }

        [Fact]
        public void RandomTests_50k()
        {
            test.RandomTests(sorter, 50000);
        }
    }
}
