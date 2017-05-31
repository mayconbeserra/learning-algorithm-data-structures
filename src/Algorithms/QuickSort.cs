using System;
using System.Collections.Generic;

namespace Learning.Algorithms
{
    public class QuickSort
    {
        public int[] From(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        private void Sort(int[] array, int left, int right)
        {
            if (left >= right) return;

            int pivot = array[(left + right) / 2];
            int index = Partition(array, left, right, pivot);

            Sort(array, left, index -1);
            Sort(array, index, right);
        }

        private int Partition(int[] array, int left, int right, int pivot)
        {
            while(left <= right)
            {
                while(array[left] < pivot)
                    left++;
                
                while(array[right] > pivot)
                    right--;

                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        private void Swap(int[] array, int left, int right)
        {
            var temp = array[right];
            array[right] = array[left];
            array[left] = temp;
        }
    }
}