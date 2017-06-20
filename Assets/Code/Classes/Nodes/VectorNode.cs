using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding.Core
{
    class VectorNode : MonoBehaviour, INode<Vector2>
    {
        public List<Vector2> AdjacentsNodes { get; set; }
        public Vector2 PreviusNode { get; set; }
        public Vector2 CurrentPosition { get; set; }
        public string NodeID { get; set; }
        public bool IsWalkable { get; set; }

        public void ClearNode()
        {
            PreviusNode = Vector2.zero;
        }
    }
}
