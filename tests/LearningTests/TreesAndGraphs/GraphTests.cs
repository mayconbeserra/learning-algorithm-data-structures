using System;
using Xunit;
using FluentAssertions;
using Learning.DataStructures.TreesAndGraphs;

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
    }
}
