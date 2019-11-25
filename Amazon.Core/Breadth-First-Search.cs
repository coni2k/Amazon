using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BreadthFirstSearch
{
    public class Node
    {
        public string value;
        public IList<Node> nodes = new List<Node>();
        public bool Visited = false;
        public Node(string x) { value = x; }
    }

    public static class Solution
    {
        public static void Run(Node rootNode)
        {
            Search(new List<Node>() { rootNode });
        }

        private static void Search(IEnumerable<Node> nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.Visited)
                    System.Console.WriteLine(node.value);

                node.Visited = true;

                var unvisited = node.nodes.Where(x => !x.Visited);

                Search(unvisited);
            }
        }
    }

    public static class TestData
    {
        public static Node GetTestData()
        {
            var nodeA = new Node("a");
            var nodeB = new Node("b");
            var nodeC = new Node("c");
            var nodeD = new Node("d");
            var nodeE = new Node("e");
            var nodeF = new Node("f");
            var nodeG = new Node("g");
            var nodeH = new Node("h");
            var nodeS = new Node("s");

            nodeA.nodes.Add(nodeB);
            nodeA.nodes.Add(nodeS);

            nodeB.nodes.Add(nodeA);

            nodeS.nodes.Add(nodeA);
            nodeS.nodes.Add(nodeC);
            nodeS.nodes.Add(nodeG);

            nodeC.nodes.Add(nodeD);
            nodeC.nodes.Add(nodeE);
            nodeC.nodes.Add(nodeF);
            nodeC.nodes.Add(nodeS);

            nodeG.nodes.Add(nodeS);
            nodeG.nodes.Add(nodeF);
            nodeG.nodes.Add(nodeH);

            nodeD.nodes.Add(nodeC);

            nodeE.nodes.Add(nodeC);
            nodeE.nodes.Add(nodeH);

            nodeF.nodes.Add(nodeC);
            nodeF.nodes.Add(nodeG);

            nodeH.nodes.Add(nodeE);
            nodeH.nodes.Add(nodeG);

            return nodeA;
        }
    }
}
