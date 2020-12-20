using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5B
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
            if (GetNodeByID(from) != null)
                this.GetNodeByID(from).AddEdge(new GraphNode<T>(to));
        }

        public void RemoveEdge(T from, T to)
        {
            if (GetNodeByID(from) != null)
                this.GetNodeByID(from).RmvEdge(new GraphNode<T>(to));
        }

        public string DisplayGraph()
        {
            string output = "";

            foreach (GraphNode<T> n in nodes)
            {
                output += "ID: " + n.ID.ToString() + Environment.NewLine;
            }
            return output;
        }

        public void DepthFirstTraverse(T startID, ref List<T> visited)
        {
            //LinkedList<T> adj;
            Stack<T> toVisit = new Stack<T>();
            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Push(startID);

            while (toVisit.Count != 0)
            {
                current.ID = toVisit.Pop();
                visited.Add(current.ID);
                foreach (T node in this.GetNodeByID(current.ID).GetAdjList())
                {
                    if (!toVisit.Contains(node) && !visited.Contains(node))
                        toVisit.Push(node);
                }
            }
        }
        public void BreadthFirstTraverse(T startID, ref List<T> visited)
        {
            //LinkedList<T> adj;
            Queue<T> toVisit = new Queue<T>();
            GraphNode<T> current = new GraphNode<T>(startID);

            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                current.ID = toVisit.Dequeue();
                visited.Add(current.ID);
                foreach (T node in this.GetNodeByID(current.ID).GetAdjList())
                {
                    if (!toVisit.Contains(node) && !visited.Contains(node))
                        toVisit.Enqueue(node);
                }
            }
        }
        public List<T> Mothervertex()
        {
            List<T> output = new List<T>();
            foreach (GraphNode<T> node in nodes)
            {
                List<T> testList = new List<T>();
                this.BreadthFirstTraverse(node.ID, ref testList);
                if (testList.Count == this.NumNodesGraph())
                    output.Add(node.ID);
            }
            return output;
        }
    }
}
