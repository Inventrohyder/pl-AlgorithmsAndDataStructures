using System;
using ads2_sorting;
using Xunit;

namespace ads2_sorting_tests
{
    public class MergeSortTests
    {
        BaseSortTests<MergeSort<int>> test = new BaseSortTests<MergeSort<int>>();
        MergeSort<int> sorter = new MergeSort<int>();

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
