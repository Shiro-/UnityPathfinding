using UnityEngine;
using System.Collections;

public class Graph
{
    //Keeping track of the rows and cols
    public int rows = 0;
    public int cols = 0;
    //Keeping track of the nodes
    public Node[] nodes;

    //Graph that takes a 2d array representing the rows and cols
    public Graph(int[,] grid)
    {
        rows = grid.GetLength(0);
        cols = grid.GetLength(1);

        //Node data
        nodes = new Node[grid.Length];

        //Loop through all the spaces
        for (var i = 0; i < nodes.Length; i++)
        {
            //Node for the array
            var node = new Node();
            //Label
            node.lbl = i.ToString();
            //Set the node in the current position
            nodes[i] = node;
        }
    }
}
