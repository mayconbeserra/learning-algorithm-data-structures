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

            Dictionary<char, int> list = new Dictionary<char, int>();
            
            foreach(char val in value.ToCharArray())
            {
                if (!list.ContainsKey(val)) list[val] = 1;
                else list[val] = list[val] + 1;
            }

            return String.Join("", list.Select(x => $"{x.Key}{x.Value}"));
            
            /* StringBuilder sb = new StringBuilder();
            
            foreach(var dict in list)
            {
                sb.Append($"{dict.Key}{dict.Value}");
            }

            return sb.ToString(); */
        }
    }
}