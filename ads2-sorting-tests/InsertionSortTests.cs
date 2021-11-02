using System;
using Xunit;
using ads2_sorting;

namespace ads2_sorting_tests
{
    public class InsertionSortTests
    {
        BaseSortTests<InsertionSort<int>> test = new BaseSortTests<InsertionSort<int>>();
        InsertionSort<int> sorter = new InsertionSort<int>();

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
    }
}
