using System;

namespace Learning.DataStructures.ArraysAndStrings
{
    public class URLify
    {
        public string Transform(string url)
        {
            return url.Trim().Replace(" ","%20");
        }
    }
}