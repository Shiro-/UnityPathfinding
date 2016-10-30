using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Search
{
    //Reference to graph
    public Graph graph;
    //Keep track of our nodes
    public List<Node> possible;
    public List<Node> visited;
    public List<Node> path;
    //End goal
    public Node endNode;
    //Keep track of our iterations
    public int iter;
    //Check if the search is done
    public bool isDone;

    //Search class
    public Search(Graph graph)
    {
        this.graph = graph;
    }

    //Start for indicating our start and end
    public void Start(Node start, Node end)
    {
        //Create a list for nodes possible
        possible = new List<Node>();
        //The starting point will always be reachable
        possible.Add(start);

        //Set the end node to be the end
        endNode = end;

        //Keep track of all nodes visited
        visited = new List<Node>();
        //Keep track of our path
        path = new List<Node>();
        //Reset iterations
        iter = 0;

        //Go through the graph and clear out the nodes
        for (var i = 0; i < graph.nodes.Length; i++)
        {
            //Get the node and clear it
            graph.nodes[i].Clear();
        }
    }
}
