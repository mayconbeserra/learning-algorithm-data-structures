using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Learning.DataStructures.ArraysAndStrings
{
    public class StringCompression
    {
        public string Compress(string value)
        {
            if (String.IsNullOrEmpty(value)) return string.Empty;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            foreach(char val in value.ToCharArray())
            {
                if (!dict.ContainsKey(val)) dict[val] = 1;
                else dict[val] = dict[val] + 1;
            }
            
            StringBuilder sb = new StringBuilder();

            dict.Select(x => sb.Append($"{x.Key}{x.Value}"));

            return sb.ToString();
            
            /* StringBuilder sb = new StringBuilder();
            
            foreach(var dict in list)
            {
                sb.Append($"{dict.Key}{dict.Value}");
            }

            return sb.ToString(); */
        }
    }
}