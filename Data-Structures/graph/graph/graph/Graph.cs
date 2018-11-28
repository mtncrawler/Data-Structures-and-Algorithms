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
        /// Constructor for graph
        /// </summary>
        /// <param name="vertices">number of vertices</param>
        /// <param name="vertex">new vertex Node</param>
        /// <param name="weight">new vertex weight</param>
        public Graph(int vertices, LinkedListNode<object> vertex, int weight)
        {
            AdjacencyList = new LinkedList<Tuple<LinkedListNode<object>, int>>[vertices];

            for (int i = 0; i < AdjacencyList.Length; i++)
            {
                AdjacencyList[i] = new LinkedList<Tuple<LinkedListNode<object>, int>>();
            }

            AdjacencyList[0].AddFirst(new Tuple<LinkedListNode<object>, int>(vertex, weight));
        }

        /// <summary>
        /// Add edge to parent
        /// </summary>
        /// <param name="parent">parent vertex</param>
        /// <param name="child">child vertex</param>
        public void AddEdge(LinkedListNode<object> parent, LinkedListNode<object> child, int weight)
        {
            foreach (var item in AdjacencyList)
            {
                if (item.Count >= 1 && item.First().Item1.Value == parent.Value)
                {
                    item.AddLast(new Tuple<LinkedListNode<object>, int>(child, weight));
                }
            }

            for (int i = 0; i < AdjacencyList.Length; i++)
            {
                if (AdjacencyList[i].Count == 0)
                {
                    AdjacencyList[i].AddFirst(new Tuple<LinkedListNode<object>, int>(child, weight));
                    break;
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
        public List<Tuple<LinkedListNode<object>, int>> GetNeighbors(LinkedListNode<object> target, int weight)
        {
            List<Tuple<LinkedListNode<object>, int>> output = new List<Tuple<LinkedListNode<object>, int>>();

            for (int i = 0; i < AdjacencyList.Length; i++)
            {
                if (AdjacencyList[i].Count >= 1 && AdjacencyList[i].First().Item1.Value == target.Value)
                {
                    foreach (var item in AdjacencyList[i])
                    {
                        output.Add(item);
                    }
                    break;
                }
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
