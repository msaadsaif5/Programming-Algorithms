using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Sort
{
    public class MergeSorter
    {
        public static List<int> MergeSort(List<int> list){
            return MergeSort(list, new int[list.Count], 0, list.Count - 1);
        }

        private static List<int> MergeSort(List<int> list, int[] temp, int left, int right){
            if (left >= right)
                return list;
            int mid = (left + right) / 2;
            MergeSort(list, temp, left, mid);
            MergeSort(list, temp, mid + 1, right);
            return MergeHalves(list, temp, left, right);
        }

        private static List<int> MergeHalves(List<int> list, int[] temp, int left, int right)
        {
            int mid = (left + right) /2;
            int size = right - left +1;

            int leftStart = left;
            int rightStart = mid + 1; 
            int index = leftStart;

            while (leftStart <= mid && rightStart <= right){
                if (list[leftStart] <= list[rightStart]){
                    temp[index] = list[leftStart];
                    leftStart++;
                }
                else{
                    temp[index] = list[rightStart];
                    rightStart++;
                }
                index++;
            }
        }
    }
}