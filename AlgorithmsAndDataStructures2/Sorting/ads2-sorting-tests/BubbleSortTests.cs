using System;
using ads2_sorting;
using Xunit;

namespace ads2_sorting_tests
{
    public class BubbleSortTests
    {
        BaseSortTests<BubbleSort<int>> test = new BaseSortTests<BubbleSort<int>>();
        BubbleSort<int> sorter = new BubbleSort<int>();

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
