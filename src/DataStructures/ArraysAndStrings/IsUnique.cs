using System;

namespace Learning.DataStructures.ArraysAndStrings
{
    public class IsUnique
    {
        public bool Check(string sentence)
        {
            bool[] set = new bool[256];

            for(int i = 0; i < sentence.Length; i++)
            {
                int val = sentence[i];
                if (set[val]) return false;

                set[val] = true;
            }

            return true;
        }
    }
}