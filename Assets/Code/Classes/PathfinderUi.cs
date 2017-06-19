using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Pathfinding.Core;

namespace Pathfinding.Ui
{
    class PathfinderUi
    {
        public GameObject _mapObject;
        /// <summary>
        /// <para>Get image of the game object</para>
        /// </summary>
        /// <param name="lbl"><para>node name</para></param>
        /// <returns></returns>

        public Image GetImage(string lbl)
        {
            //Convert the label into a number
            var id = Int32.Parse(lbl);
            //Get a reference to the game object
            var go = _mapObject.transform.GetChild(id).gameObject;

            //Return the image component
            return go.GetComponent<Image>();
        }

        /// <summary>
        /// <para>Reset colors of the map</para>
        /// </summary>
        public void ResetMap(IGraph graph)
        {
            //For each node in our graph
            foreach (var node in graph.Nodes)
            {
                //Check if the node is open or solid
                //Open is grey
                //Solid is white
                GetImage(node.NodeName).color = node.Nodes.Count == 0 ? Color.white : Color.gray;
            }
        }
    }
}
