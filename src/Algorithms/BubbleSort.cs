using System;

namespace Learning.Algorithms
{
    public class BubbleSort
    {
        public int[] From(int[] source)
        {
            bool swapped = true;
            while(swapped)
            {
                swapped = false;
                for (int i = 1; i < source.Length; i++)
                {
                    if (source[i - 1] > source[i])
                    {
                        int temp = source[i - 1];
                        source[i - 1] = source[i];
                        source[i] = temp;
                        swapped = true;
                    }
                }
            }

            return source;
        }
    }
}