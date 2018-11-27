using System;
using System.Collections.Generic;
using System.Text;

namespace graph
{
    class Graph
    {
        public LinkedList<LinkedList<Tuple<Node, int>>> AdjacencyList { get; set; }

        public Graph()
        {
            AdjacencyList = new LinkedList<LinkedList<Tuple<Node, int>>>();
        }


    }
}
