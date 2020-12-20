using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace GraphTask5A
{
    public class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;

        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }

        public int NumNodesGraph()
        {
            return nodes.Count;
        }

        public int NumEdgesGraph()
        {
            int count = 0;
            foreach (GraphNode<T> n in nodes)
            {
                count += n.GetAdjList().Count;
            }
            return count;
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(node.ID) == 0)
                    return true;
            }
            return false;
        }

        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            //Hint: Find the node “from” in the list of nodes and then search its adjList to see if there is node “to” 
            if (this.ContainsGraph(from))
                return this.nodes.Find(from).Value.GetAdjList().Contains(to.ID);
            return false; // from doesnt exist in the graph
        }

        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public GraphNode<T> GetNodeByID(T id)
        {
            //Hint: Search through the list of nodes for a node with this id
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(id) == 0)
                    return n;
            }
            return null; // node with id doesnt exist in graph
        }

        public void AddEdge(T from, T to)
        {
            //Hint: Find the node with id “from” in the list of nodes and then
            //use the GraphNode method to add an edge to the node with id “to”
            if (GetNodeByID(from) != null)
                this.GetNodeByID(from).AddEdge(new GraphNode<T>(to));
        }

        public string DisplayGraph()
        {
            string output = "";

            foreach(GraphNode<T> n in nodes)
            {
                output += "ID: " + n.ID.ToString() + "\t" + "Edges: " + n.GetAdjList().Count() + Environment.NewLine;
            }
            return output;
        }
    }
}
