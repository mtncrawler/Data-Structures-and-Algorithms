# Graphs

A graph is a non-linear data structure that can be looked at as a a collection of points made up of vertices (or nodes) potentially being connected by line segments named edges.  

## Challenge
Implement your a Graph class. The graph should be represented as an adjacency list. that includes the following:  

*AddEdge()  

*GetNodes()  

*GetNeighbors()  

*Size()  

## Approach & Efficiency
*AddEdge()  
	- Time O(n)  
	- Space O(1)  
*GetNodes()  
	- Time O(n)  
	- Space O(n)  
*GetNeighbors()  
	- Time O(n)  
	- Space O(n)  
*Size()  
	- Time O(1)  
	- Space O(1)  

## API
*AddEdge()  
	- Adds a new vertice to the graphs  
	- Include the ability to have a “weight”  
	- Bring in both the parent node, and the new node to be added  
*GetNodes()  
	- returns all of the nodes in the graph as a collection  
*GetNeighbors()  
	- returns a collection of nodes connected to the given node  
	- Bring in a given node  
	- Include the weight from the given node    
*Size()  
	- returns the total number of nodes in the graph  
