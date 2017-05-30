using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.TreesAndGraphs;
using System.Linq;

namespace Learning.DataStructures.TreesAndGraphs.Tests
{
    public class GraphTests
    {
        [Fact]
        public void It_Should_Add_SeveralNodes()
        {
            Graph<int> graph = new Graph<int>();

            graph.Add(10);
            graph.Add(20);
        }

        [Fact]
        public void It_Should_Add_DirectEdge()
        {
            Graph<string> graph = new Graph<string>();

            var berlin = graph.Add("Berlin");
            var hamburg = graph.Add("Hamburg");
            var stuttgart = graph.Add("Stuttgart");
            var dusseldorf = graph.Add("Dusseldorf");
            var munchen = graph.Add("munich");

            graph.AddDirectedEdge(berlin, hamburg);
            graph.AddDirectedEdge(berlin, stuttgart);
            graph.AddDirectedEdge(stuttgart, dusseldorf);
            graph.AddDirectedEdge(dusseldorf, berlin);

            graph.HasPathDFS(berlin, hamburg).Should().BeTrue();
            graph.HasPathDepthFirst(dusseldorf, berlin).Should().BeTrue();
        }

        [Fact]
        public void It_Should_Breadth_FirstSearch()
        {
            Graph<string> graph = new Graph<string>();

            var berlin = graph.Add("Berlin");
            var hamburg = graph.Add("Hamburg");
            var stuttgart = graph.Add("Stuttgart");
            var dusseldorf = graph.Add("Dusseldorf");
            var munchen = graph.Add("munich");

            graph.AddDirectedEdge(berlin, hamburg);
            graph.AddDirectedEdge(berlin, stuttgart);
            graph.AddDirectedEdge(stuttgart, dusseldorf);
            graph.AddDirectedEdge(dusseldorf, berlin);

            graph.HasPathBreadthFirst(berlin, dusseldorf).Should().BeTrue();
        }

        [Fact]
        public void It_Should_Breadth_FirstSearch_And_Dont_Find_Any_Path()
        {
            Graph<string> graph = new Graph<string>();

            var berlin = graph.Add("Berlin");
            var hamburg = graph.Add("Hamburg");
            var stuttgart = graph.Add("Stuttgart");
            var dusseldorf = graph.Add("Dusseldorf");
            var munchen = graph.Add("munich");

            graph.AddDirectedEdge(berlin, hamburg);
            graph.AddDirectedEdge(berlin, stuttgart);
            graph.AddDirectedEdge(stuttgart, dusseldorf);
            graph.AddDirectedEdge(dusseldorf, berlin);

            graph.HasPathBreadthFirst(berlin, munchen).Should().BeFalse();
        }

        [Theory]
        [InlineData("A", "A", 0)]
        [InlineData("A", "B", 1)]
        [InlineData("A", "E", 2)]
        [InlineData("A", "F", 2)]
        public void It_Should_Search_ShortestPath_Between_Two_Nodes(string start, string end, int distance)
        {
            Graph<string> graph = new Graph<string>();

            var A = graph.Add("A");
            var B = graph.Add("B");
            var C = graph.Add("C");
            var D = graph.Add("D");
            var E = graph.Add("E");
            var F = graph.Add("F");
            var G = graph.Add("G");
            var H = graph.Add("H");

            graph.AddDirectedEdge(A, B);
            graph.AddDirectedEdge(A, G);
            graph.AddDirectedEdge(A, D);

            graph.AddDirectedEdge(B, E);
            graph.AddDirectedEdge(B, F);

            graph.AddDirectedEdge(E, G);

            graph.AddDirectedEdge(F, D);
            graph.AddDirectedEdge(F, C);

            graph.AddDirectedEdge(C, H);

            graph.ShortestPath
            (
                graph.NodeSet.FirstOrDefault(x => x.Data == start),
                graph.NodeSet.FirstOrDefault(x => x.Data == end)
            )
            .Value.Should().Be(distance);
        }
    }
}
