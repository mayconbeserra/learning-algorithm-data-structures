using System;
using System.Collections.Generic;

namespace Learning.Algorithms
{
    public class MergeSort
    {
        public int[] From(int[] source)
        {
            return Sort(source, new int[source.Length], 0, source.Length -1);
        }

        private int[] Sort(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd) return temp;

            int middle = (leftStart + rightEnd) / 2;

            // Console.WriteLine($"Arr: {array} - tmp: {temp} - leftStart: {leftStart} - Middle: {middle}");
            Sort(array, temp, leftStart, middle);

            // Console.WriteLine($"Arr: {array} - tmp: {temp} - Middle + 1: {middle + 1} - Right: {rightEnd}");
            Sort(array, temp, middle + 1, rightEnd);

            // Console.WriteLine($"==== Merge ======");
            // Console.WriteLine($"Arr: {array} - tmp: {temp} - leftStart: {leftStart} - Middle: {middle}");
            return Merge(array, temp, leftStart, rightEnd);
        }

        private int[] Merge(int[] array, int[] temp, int leftStart, int rightEnd)
        {
            int leftEnd = (rightEnd + leftStart) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while(left <= leftEnd && right <= rightEnd)
            {
                if (array[left] <= array[right])
                {
                    temp[index] = array[left];
                    left++;
                } else 
                {
                    temp[index] = array[right];
                    right++; 
                }

                index++;
            }

            System.Array.Copy(array, left, temp, index, leftEnd - left + 1);
            System.Array.Copy(array, right, temp, index, rightEnd - right + 1);
            System.Array.Copy(temp, leftStart, array, leftStart, size);

            return temp;
        }
    }
}