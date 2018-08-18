using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorters
{
    public class MergeSorter
    {
        public static List<int> MergeSort(List<int> list)
        {
            return MergeSort(list, 0, list.Count - 1);
        }

        private static List<int> MergeSort(List<int> list, int left, int right)
        {
            if (right <= left)
                return list;

            int mid = left + (right - left) / 2;

            MergeSort(list, left, mid);
            MergeSort(list, mid + 1, right);

            return Merge(list, left, mid, right);
        }

        private static List<int> Merge(List<int> list, int left, int mid, int right)
        {
            int leftIndex = left;
            int rightIndex = mid + 1;
            int index = 0;

            if (rightIndex - leftIndex == 1)
            {
                if (list[leftIndex] > list[rightIndex])
                {
                    int t = list[leftIndex];
                    list[leftIndex] = list[rightIndex];
                    list[rightIndex] = t;
                }
                return list;
            }

            int tmpSize = right - left + 1;
            var tmp = new int[tmpSize];

            while (leftIndex <= mid && rightIndex <= right)
            {
                if (list[leftIndex] <= list[rightIndex])
                {
                    tmp[index] = list[leftIndex];
                    leftIndex++;
                }
                else
                {
                    tmp[index] = list[rightIndex];
                    rightIndex++;
                }
                index++;
            }

            while (leftIndex <= mid)
            {
                tmp[index] = list[leftIndex];
                leftIndex++;
                index++;
            }

            while (rightIndex <= right)
            {
                tmp[index] = list[rightIndex];
                rightIndex++;
                index++;
            }

            int c = 0;
            while (left <= right)
            {
                list[left] = tmp[c];
                left++;
                c++;
            }

            return list;
        }

    }
}
