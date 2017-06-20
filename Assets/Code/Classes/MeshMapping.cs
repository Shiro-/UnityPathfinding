using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pathfinding.Core
{
    class MeshMapping
    {
        private List<GameObject> _nodes;
        private List<GameObject> _readyNodes;
      //  public List<GameObject> Nodes { get { return (_nodes != null) ? _nodes : throw new Exception("Node list not initialized"); } }

        public Vector2[] MeshSize { get; set; }
        /// <summary>
        /// <para>This is the cast size for detect ilegal walk areas</para>
        /// </summary>
        public Vector2 _castSize;

        /// <summary>
        /// <para>Here you need to put what are the ilegal walk areas</para>
        /// </summary>
        public LayerMask _ilegalWalkAreas;

        private NodesIntantiator _nodesIntanstiator;

        public MeshMapping(NodesIntantiator instantiator)
        {
            _nodesIntanstiator = instantiator;

            _nodes = new List<GameObject>(4);
            _readyNodes = new List<GameObject>();
        }

        public void CreateMesh(/*Vector2[] vectices*/)
        {
            //_meshSize = meshSize; //Comment for now, testing...
            MeshSize = new Vector2[] //Test, vertices, Fill the entire playable scene
            {
                new Vector2(-3.53f, -1.19f),
                new Vector2(2.57f, -1.19f),
                new Vector2(-3.53f, 2.46f),
                new Vector2(2.57f, 2.46f)
            };

            AddComponentsToNodes();
        }
        
        private void AddComponentsToNodes()
        {
            for (int i = 0; i < 5; i++)
            {                
                //   node.hideFlags = HideFlags.HideInHierarchy; //Dont show in hierarchy
                var x = new GameObject("Node");
                var castZone = x.AddComponent<NodeCast>();
                var iss = x.AddComponent<VectorNode>().IsWalkable = VerifyIfIsWalkable(castZone, x); //Just putting if is walkable or not ;)
                Debug.Log("Walkable " + iss);                                                        //_nodesIntanstiator.intantiateAllNodes(x);
            }
        }

        private bool VerifyIfIsWalkable(NodeCast cast, GameObject node)
        {
            return cast.CastZone(node, _castSize, _ilegalWalkAreas);
        }

        private void PlaceNodes()
        {

        }

        private void FromMeshToTwoDimensionalArray()
        {

        }

        
    }
}
