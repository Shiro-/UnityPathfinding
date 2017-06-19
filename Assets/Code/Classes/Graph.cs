using UnityEngine;
using System.Collections;
using System;

namespace Pathfinding.Core
{
    public class Graph : IGraph
    {
        //Keeping track of the rows and cols
        public int Rows { get; set; }
        public int columns { get; set; }

        //Keeping track of the nodes
        public Node[] Nodes { get; set; }

        private int[,] _grid;

        /// <summary>
        /// <para>Graph that takes a 2d array representing the rows and columns</para>
        /// </summary>
        public Graph(int[,] grid)
        {
            _grid = grid;
            Rows = _grid.GetLength(0);
            columns = _grid.GetLength(1);

            //Node data
            Nodes = new Node[_grid.Length];         
        }

        public void MainOperation()
        {
            LoopThroughSpaces();
            LoopThroughRows();
        }       

        private void LoopThroughSpaces()
        {
            //Loop through all the spaces
            for (var i = 0; i < Nodes.Length; i++)
            {
                //Node for the array
                var node = new Node();
                //Label
                node.NodeName = i.ToString();
                //Set the node in the current position
                Nodes[i] = node;
            }           
        }

        private void LoopThroughRows() 
        {
            //Iterate through rows
            for (var r = 0; r < Rows; r++)
            {
                //Iterate through cols
                for (var c = 0; c < columns; c++)
                {
                    //Get the node reference
                    var node = Nodes[columns * r + c];

                    //Test the grid
                    //1 solid or unwalkable area
                    //0 open or walkable area

                    if (_grid[r, c] == 1)
                    {
                        //Skip current iteration
                        continue;
                    }

                    //Up direction
                    if (r > 0)
                    {
                        //Add nodes above current
                        AddNodes(node, Nodes[columns * (r - 1) + c]);
                    }

                    //Right direction
                    if (c < columns - 1)
                    {
                        AddNodes(node, Nodes[columns * r + c + 1]);
                    }

                    //Down Direction
                    if (r < Rows - 1)
                    {
                        AddNodes(node, Nodes[columns * (r + 1) + c]);
                    }

                    //Left Direction
                    if (c > 0)
                    {
                        AddNodes(node, Nodes[columns * r + c - 1]);
                    }
                }
            }
        }

        private void AddNodes(INode nodeInstance, Node node)
        {
            nodeInstance.Nodes.Add(node);
        }

    }

}
