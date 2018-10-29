using System;
using System.Collections.Generic;
using System.Text;

namespace trees.classes
{
    class BinaryTree
    {
        public Node Root { get; set; }
        
        public BinaryTree(Node value)
        {
            Root = value;
        }

        public List<int> PreOrder(Node node, List<int> output)
        {
            output.Add(node.Value);

            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, output);
            }
            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, output);
            }

            return output;
        }
    }
}
