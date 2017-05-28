using System;
using System.Collections;
using System.Collections.Generic;

namespace Learning.DataStructures.TreesAndGraphs
{
    public class Graph<T>
    {
        public IList<NodeGraph<T>> NodeSet { get; set; } = new List<NodeGraph<T>>();

        public NodeGraph<T> Add(T value)
        {
            NodeGraph<T> nodeGraph = new NodeGraph<T>(value);
            NodeSet.Add(nodeGraph);

            return nodeGraph;
        }

        public void AddDirectedEdge(NodeGraph<T> origin, NodeGraph<T> destiny)
        {
            origin.Neighbors.Add(destiny);
        }

        public bool HasPathDFS(NodeGraph<T> source, NodeGraph<T> destination)
        {
            HashSet<T> visited = new HashSet<T>();

            return HasPathDFS(source, destination, visited);
        }

        // Depth First Search
        public bool HasPathDFS(NodeGraph<T> source, NodeGraph<T> destination, HashSet<T> visited)
        {
            if (visited.Contains(source.Data)) return false;

            Console.WriteLine($"{source.Data} - {destination.Data}");

            visited.Add(source.Data);

            if (source.Data.Equals(destination.Data)) return true;

            foreach(var child in source.Neighbors)
            {
                if (HasPathDFS(child, destination, visited)) return true;
            }

            return false;
        }

        public bool HasPathDepthFirst(NodeGraph<T> start, NodeGraph<T> end)
        {
            HashSet<T> visited = new HashSet<T>();

            return HasPathDepthFirst(start, end, visited);
        }

        public bool HasPathDepthFirst(NodeGraph<T> start, NodeGraph<T> end, HashSet<T> visited)
        {
            if (visited.Contains(start.Data)) return false;

            visited.Add(start.Data);

            if (start.Data.Equals(end.Data)) return true;

            foreach (var child in start.Neighbors)
            {
                if (HasPathDepthFirst(child, end, visited)) return true;
            }

            return false;
        }

        public bool HasPathBreadthFirst(NodeGraph<T> source, NodeGraph<T> destination)
        {
            Queue<NodeGraph<T>> queue = new Queue<NodeGraph<T>>();

            queue.Enqueue(source);

            while(queue.Count > 0)
            {
                var node = queue.Dequeue();

                // Visit(node)
                if (node.Data.Equals(destination.Data)) return true;
                if (node.Visited) continue;
                
                Console.WriteLine($"{node.Data} - {destination.Data}");

                node.Visited = true;

                foreach(var child in node.Neighbors)
                    queue.Enqueue(child);
            }

            return false;
        }
    }

    public class NodeGraph<T>
    {
        public T Data { get; set;}
        public bool Visited { get; set; }
        public IList<NodeGraph<T>> Neighbors { get; set;}

        public NodeGraph(T value)
        {
            Data = value;
            Neighbors = new List<NodeGraph<T>>();
        }
    }
}