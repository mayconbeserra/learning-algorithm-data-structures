using System;

namespace Learning.Algorithms
{
    public class BinarySearch
    {
        public int Search(int[] source, int value)
        {
            int low = 0;
            int high = source.Length - 1;
            int mid = 0;

            while (low <= high)
            {
                mid = (low + high) / 2;
                if (source[mid] < value)
                {
                    low = mid + 1;
                } else if (source[mid] > value)
                {
                    high = mid - 1;
                } else return source[mid];
            }

            return -1;
        }
    }
}