using System;
using System.Collections.Generic;
using System.Text;

namespace stackAndQueue.classes
{
    public class Queue
    {
        public Node Front { get; set; }

        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// return the front node 
        /// </summary>
        /// <returns>front node</returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// add a node to the queue
        /// </summary>
        /// <param name="node">node to be added</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// remove the front from the queue
        /// </summary>
        /// <returns>the removed node</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;
            
            return temp;
        }


    }
}
