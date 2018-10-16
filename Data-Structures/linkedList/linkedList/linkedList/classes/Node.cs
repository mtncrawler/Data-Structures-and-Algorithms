using System;
using System.Collections.Generic;
using System.Text;

namespace linkedList.classes
{
    class Node
    {
        public object Value { get; set; }
        
        public Node Next { get; set; }
        
        public Node(object value)
        {
            Value = value;
        }

    }
}
