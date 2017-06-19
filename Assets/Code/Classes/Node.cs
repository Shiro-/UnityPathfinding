//The node will represent a place on the map/grid
//This is the most important part of the algorithm

using UnityEngine;
using System.Collections.Generic;
namespace Pathfinding.Core
{
    public class Node: INode
    {
        //List for the nodes
        public List<Node> Nodes { get; set; }
        public Node PreviusNode { get; set; }
        //Name for nodes
        public string NodeName { get; set; }

        public Node()
        {
            Nodes = new List<Node>();
            PreviusNode = null;
            NodeName = "";
        }

        //Clear the node
        public void ClearNode()
        {
            PreviusNode = null;
        }
    }
}