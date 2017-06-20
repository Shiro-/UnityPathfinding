//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using UnityEngine;

//namespace Pathfinding.Core
//{
//    class VectorGraph
//    {
//        //Keeping track of the rows and cols
//        public int Rows { get; set; }
//        public int columns { get; set; }

//        //Keeping track of the nodes
//        public VectorNode[] Nodes { get; set; }

//        private Vector2[,] _grid;
//        public bool IsWalkable { get; set; }
//        /// <summary>
//        /// <para>Graph that takes a 2d array representing the rows and columns</para>
//        /// </summary>
//        public VectorGraph(Vector2[,] grid)
//        {
//            _grid = grid;
//            Rows = _grid.GetLength(0); //Array dimension
//            columns = _grid.GetLength(1);

//            //Node data
//            Nodes = new VectorNode[_grid.Length];
//        }

//        public void MainOperation()
//        {
//            LoopThroughSpaces();
//            LoopThroughRows();
//        }

//        /// <summary>
//        /// <para>Loop through all avaliables espaces</para>
//        /// </summary>
//        private void LoopThroughSpaces()
//        {
//            //Loop through all the spaces
//            for (var i = 0; i < Nodes.Length; i++)
//            {
//                //Node for the array
//                var node = new T();

//                //Label or Node ID
//                node.NodeID = i.ToString();

//                //Set the node in the current position
//                Nodes[i] = node;
//            }
//        }

//        private void LoopThroughRows()
//        {
//            //Iterate through rows
//            for (var r = 0; r < Rows; r++)
//            {
//                //Iterate through cols
//                for (var c = 0; c < columns; c++)
//                {
//                    //Get the node reference
//                    var node = Nodes[columns * r + c];

//                    //Test the grid
//                    //1 solid or unwalkable area
//                    //0 open or walkable area

//                    if (IsWalkable)
//                    {
//                        //Skip current iteration
//                        continue;
//                    }

//                    //Up direction
//                    if (r > 0)
//                    {
//                        //Add nodes above current
//                        AddNodes(node, Nodes[columns * (r - 1) + c]);
//                    }

//                    //Right direction
//                    if (c < columns - 1)
//                    {
//                        AddNodes(node, Nodes[columns * r + c + 1].);
//                    }

//                    //Down Direction
//                    if (r < Rows - 1)
//                    {
//                        AddNodes(node, Nodes[columns * (r + 1) + c]);
//                    }

//                    //Left Direction
//                    if (c > 0)
//                    {
//                        AddNodes(node, Nodes[columns * r + c - 1]);
//                    }
//                }
//            }
//        }

//        /// <summary>
//        /// <para>Nodes who will create the walk path</para>
//        /// </summary>
//        /// <param name="nodeInstance"><para>Node object instance</para></param>
//        /// <param name="node"><para>Node to add</para></param>
//        private void AddNodes(INode<Vector2> nodeInstance, Vector2 node)
//        {
//            nodeInstance.AdjacentsNodes.Add(node);
//        }

//    }
//}
