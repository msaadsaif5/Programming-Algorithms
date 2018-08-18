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
        [InlineData(new int[] { 7, 10, 15, 2, 9, 5, 16, 14 })]
        public void MergeSort(IEnumerable<int> list)
        {
            var result = MergeSorter.MergeSort(list.ToList());
        }
    }
}
