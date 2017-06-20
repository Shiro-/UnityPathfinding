using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding.Core
{
    class NodesIntantiator : MonoBehaviour
    {
        public void intantiateAllNodes(List<GameObject> nodes)
        {
            
        }

        private void DestroyUnWalkableNodes(GameObject node)
        {
            Destroy(node);
        }
    }
}
