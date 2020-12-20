using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTask5A
{
    public class GraphNode<T>
    {
        private T id; // data stored in the node (“id” of the  node).
        private LinkedList<T> adjList; // adjacency list of the node
                                       //Use LinkedList from C#

        // constructor 
        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }

        // set and get the data stored in the node 
        public T ID
        {
            get { return id; }
            set { this.id = value; }
        }


        public void AddEdge(GraphNode<T> to)
        {
            if(!this.adjList.Contains(to.ID))
                this.adjList.AddLast(to.ID);
        }

        public LinkedList<T> GetAdjList()
        {
            return adjList;
        }
    }
}
