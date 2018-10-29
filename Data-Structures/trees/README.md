### Trees

## Challenge

Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.  
Create a BinaryTree class with methods for each of the depth first traversals: PreOrder, InOrder, and PostOrder which takes in a root node, and returns a list of the nodes.  

Create a BinarySearchTree class with a method named Add that adds a new node in the correct location in the binary search tree. Define a method named Search that brings in a value of node, and returns the node with the desired value.  

## Approach & Efficiency

Binary Tree:

1.	PreOrder, InOrder, PostOrder
	time O(n) -  efficiency based on the maximum number of nodes needed to traverse the tree  
	space O(H) -  efficiency based on the height of the call stack which is the height of the tree  

Binary Search Tree  

1.	Add 
	time O(log n) - each traversal helps to eliminate the branches of the opposite direction of traversal   
	space O(1) - there is no additional memory that is allocated  

2.	Search
	time O(log n) -  each traversal helps to eliminate the branches of the opposite direction of traversal  
	space O(1) - there is no additional memory that is allocated  

## Methods

Binary Tree:  
PreOrder, InOrder, PostOrder - depth-first traversal of binary tree that takes in the root node and outputs a list of nodes  

Binary Search Tree:  
Add - method that takes in a node that is added to a binary search tree  
Search - method that takes in a node that is searched for in a binary search tree; the output is the node found in the tree  
 