using Algorithms.Sorters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace UnitTests.Algorithms.Sorters
{
    public class MergeSortTest
    {
        [Theory]
        [InlineData(new int[] { 5 })]
        [InlineData(new int[] { 2, 1 })]
        [InlineData(new int[] { 7, 10, 15, 2, 9, 5, 16, 14 })]
        [InlineData(new int[] { 6, 2, 3, 1, 9, 10, 15, 13, 12, 17, 31 })]
        public void MergeSort(IEnumerable<int> list)
        {
            var result = MergeSorter.MergeSort(list.ToList());
        }
    }
}
