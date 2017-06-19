using UnityEngine;
using System.Collections;

namespace Pathfinding
{
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

            //Iterate through rows
            for (var r = 0; r < rows; r++)
            {
                //Iterate through cols
                for (var c = 0; c < cols; c++)
                {
                    //Get the node reference
                    var node = nodes[cols * r + c];

                    //Test the grid
                    //1 solid
                    //0 open
                    if (grid[r, c] == 1)
                    {
                        //Skip current iteration
                        continue;
                    }

                    //Up direction
                    if (r > 0)
                    {
                        //Add nodes above current
                        node.adj.Add(nodes[cols * (r - 1) + c]);
                    }

                    //Right direction
                    if (c < cols - 1)
                    {
                        node.adj.Add(nodes[cols * r + c + 1]);
                    }

                    //Down Direction
                    if (r < rows - 1)
                    {
                        node.adj.Add(nodes[cols * (r + 1) + c]);
                    }

                    //Left Direction
                    if (c > 0)
                    {
                        node.adj.Add(nodes[cols * r + c - 1]);
                    }
                }
            }
        }
    }

}
