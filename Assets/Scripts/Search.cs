using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Search
{
    //Reference to graph
    public Graph graph;
    //Keep track of our nodes
    public List<Node> a;
    public List<Node> b;
    public List<Node> c;
    public Node endNode;
    //Keep track of our iterations
    public int iter;
    //Check if the search is done
    public bool isDone;
}
