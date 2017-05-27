using System;

namespace Learning.DataStructures.ArraysAndStrings
{
    public class IsUnique
    {
        public bool Check(string sentence)
        {
            foreach(var val1 in sentence.ToCharArray())
                foreach(var val2 in sentence
                    .Substring(sentence.IndexOf(val1) + 1)
                    .ToCharArray()) if (val1.Equals(val2)) return false;
            return true;
        }
    }
}