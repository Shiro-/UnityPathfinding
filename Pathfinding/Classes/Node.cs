//The node will represent a place on the map/grid
//This is the most important part of the algorithm

using UnityEngine;
using System.Collections.Generic;

public class Node
{
    //List for the nodes
    public List<Node> adj = new List<Node>();
    public Node prev = null;
    //Name for nodes
    public string lbl = "";

    //Clear the node
    public void Clear()
    {
        prev = null;
    }
}
