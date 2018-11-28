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
        public Graph(int vertices, Tuple<LinkedListNode<object>, int> vertex)
        {
            AdjacencyList = new LinkedList<Tuple<LinkedListNode<object>, int>>[vertices];

            for (int i = 0; i < AdjacencyList.Length; i++)
            {
                AdjacencyList[i] = new LinkedList<Tuple<LinkedListNode<object>, int>>();
            }

            AdjacencyList[0].AddFirst(vertex);
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
                if (AdjacencyList[i].Count >= 1)
                {
                    output.Add(AdjacencyList[i].First());
                }
            }

            return output;
        }

        /// <summary>
        /// Return a list of all neighbor vertices
        /// </summary>
        /// <param name="target">vertex to find all neighbors</param>
        /// <returns>list of neighbor vertices</returns>
        public List<Tuple<LinkedListNode<object>, int>> GetNeighbors(Tuple<LinkedListNode<object>, int> target)
        {
            int index = Array.IndexOf(AdjacencyList, target);

            List<Tuple<LinkedListNode<object>, int>> output = new List<Tuple<LinkedListNode<object>, int>>();

            foreach (var item in AdjacencyList[index])
            {
                output.Add(item);
            }

            return output;
        }

        /// <summary>
        /// Find the size of the graph
        /// </summary>
        /// <returns>number of vertices</returns>
        public int Size()
        {
            return AdjacencyList.Count();
        }
    }
}
