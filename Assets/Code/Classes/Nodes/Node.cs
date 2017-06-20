//The node will represent a place on the map/grid
//This is the most important part of the algorithm

using UnityEngine;
using System.Collections.Generic;
using System;

namespace Pathfinding.Core
{
    public class Node : INode<Node>
    {
        //List for the nodes
        public List<Node> AdjacentsNodes { get; set; }
        public Node PreviusNode { get; set; }

        //Name for nodes
        public string NodeID { get; set; }
        public bool IsWalkable { get; set; }

        public Node()
        {
            AdjacentsNodes = new List<Node>();
            PreviusNode = null;
            NodeID = "";
        }

        //Clear the node
        public void ClearNode()
        {
            PreviusNode = null;
        }
    }
}