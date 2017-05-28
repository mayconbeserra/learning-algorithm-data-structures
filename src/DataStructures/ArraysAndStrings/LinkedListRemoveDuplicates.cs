using System;
using System.Collections;
using System.Collections.Generic;

namespace Learning.DataStructures.ArraysAndStrings
{
    public class RemoveDuplicates
    {
        public void Rm(LinkedList<int> tree)
        {
            var current = tree.First;
            var hash = new HashSet<int>();
            LinkedListNode<int> previous = null;

            while(current != null)
            {
                if (hash.Contains(current.Value)) 
                {
                    previous = current;
                    tree.Remove(current.Value);
                    current = previous;
                }
                else 
                {
                    hash.Add(current.Value);
                }

                current = current.Next;
            }
        }
    }
}