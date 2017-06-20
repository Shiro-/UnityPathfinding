using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding.Core
{
    class NodeCast : MonoBehaviour
    {
        public bool CastZone(GameObject currentNode, Vector2 castSize, LayerMask cast)
        {
            //If the node is colliding with a ilegal area (cast) will be false.
            return !Physics2D.BoxCast(currentNode.transform.position, castSize, 0, Vector2.zero, 0, 1 << cast); 
        }
    }
}
