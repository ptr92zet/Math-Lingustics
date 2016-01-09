using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersNFA
{
    class DepthFirstSearch
    {
        private bool[] marked;
        private int[] edgeTo;
        private int currentNodeId;
 
        public DepthFirstSearch(Graph<State> graph, int currId)
        {
            marked = new bool[graph.Count];
            edgeTo = new int[graph.Count];
            this.currentNodeId = currId;
        }
 
        public void DFS(GraphNode<State> startNode, int id)
        {
            marked[currentNodeId] = true;
 
            foreach (var childNode in startNode.Neighbors)
            {
                if (!marked[(int)childNode.Value])
                {
                    DFS(childNode, (int)childNode.Value);
                    edgeTo[(int)childNode.Value] = id;
                }
            }
        }
 
        public bool HasPathTo(int nodeId)
        {
            return marked[nodeId];
        }
 
        public IEnumerable<int> GetPathTo(int nodeId)
        {
            if (!HasPathTo(nodeId))
                return null;
 
            var stack = new Stack<int>();
 
            for (var x = nodeId; x != this.currentNodeId; x = edgeTo[x])
            {
                stack.Push(x);
            }
 
            stack.Push(currentNodeId);
 
            return stack;
        }

        public int getCurrentNodeId()
        {
            return this.currentNodeId;
        }
    }
}
