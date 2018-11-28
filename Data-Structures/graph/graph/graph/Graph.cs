using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace graph
{
    class Graph
    {
        public LinkedList<Tuple<LinkedListNode<object>, int>>[] AdjacencyList { get; set; }

        /// <summary>
        /// Create graph with given number of vertices
        /// </summary>
        /// <param name="vertices">number of vertices in graph</param>
        public Graph(int vertices)
        {
            AdjacencyList = new LinkedList<Tuple<LinkedListNode<object>, int>>[vertices];

            for (int i = 0; i < AdjacencyList.Length; i++)
            {
                AdjacencyList[i] = new LinkedList<Tuple<LinkedListNode<object>, int>>();
            }
        
        }

        /// <summary>
        /// Add edge to parent
        /// </summary>
        /// <param name="parent">parent vertex</param>
        /// <param name="child">child vertex</param>
        public void AddEdge(Tuple<LinkedListNode<object>, int> parent, Tuple<LinkedListNode<object>, int> child)
        {
            foreach (var item in AdjacencyList)
            {
                if (item.First.Value == parent)
                {
                    item.AddLast(child);
                }
            }
        }

        /// <summary>
        /// Return list of all Vertices in graph
        /// </summary>
        /// <returns>list of vertices</returns>
        public List<Tuple<LinkedListNode<object>, int>> GetNodes()
        {
            List<Tuple<LinkedListNode<object>, int>> output = new List<Tuple<LinkedListNode<object>, int>>();

            for (int i = 0; i < AdjacencyList.Length; i++)
            {
                output.Add(AdjacencyList[i].First());
            }

            return output;
        }


        public List<Tuple<LinkedListNode<object>, int>> GetNeighbors(Tuple<LinkedListNode<object>, int> target)
        {

        }

        public int Size()
        {
            return AdjacencyList.Count();
        }
    }
}
