using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Pathfinding.Core
{
    class MeshTest : MonoBehaviour
    {

        public LayerMask _layers;

        private void Start()
        {
            var mesh = new MeshMapping(GetComponent<NodesIntantiator>());
            mesh._ilegalWalkAreas = _layers;
            mesh._castSize = new Vector2(0.9f, 0.9f);
            mesh.CreateMesh();
        }
    }
}
