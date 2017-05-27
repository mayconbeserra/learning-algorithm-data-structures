using System;

namespace Learning.DataStructures.ArraysAndStrings
{
    public class IsPermutation
    {
        public bool Check(string param1, string param2)
        {
            if (param1.Length != param2.Length) return false;

            return Sort(param1).Equals(Sort(param2));
        }

        private string Sort(string value)
        {
            char[] content = value.ToCharArray();
            Array.Sort(content);

            return content.ToString();
        }
    }
}