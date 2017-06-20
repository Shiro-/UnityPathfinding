using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace Pathfinding.Core
{
    public class TestCore : MonoBehaviour
    {
        public GameObject _mapObject;

        private IGraph _graph;
        private Search _search;
        private int[,] _mapGrid;

        // Use this for initialization or whatever
        void Start()
        {            
            MapCreator();
            ObjectInitialization();
            //Step through each solution
            while (!_search.isDone)
            {
                _search.Step();
            }

            ImagesColouring();
        }

        /// <summary>
        /// <para>Create a grid for our test</para>
        /// </summary>
        private void MapCreator() //This need be created Automatically depending of the environment (TODO)
        {
            _mapGrid = new int[5, 5]
            {
               {0, 1, 0, 0, 0},
               {0, 1, 1, 0, 0}, //Like the images in unity!
               {0, 1, 1, 0, 0},
               {0, 1, 1, 0, 0},
               {0, 0, 0, 0, 0}
            };
        }

        /// <summary>
        /// <para></para>
        /// </summary>
        private void ObjectInitialization()
        {
            CreateAGraph();
            CreateASearchForTheGraph();
        }

        /// <summary>
        /// <para>Create a graph to hold our map data</para>
        /// </summary>
        private void CreateAGraph()
        {
            
            _graph = new Graph(_mapGrid);
            _graph.MainOperation();
        }

        /// <summary>
        /// <para>Create a search for the graph</para>
        /// </summary>
        private void CreateASearchForTheGraph()
        {
            _search = new Search(_graph);
            BeginSearch(_graph);
        }


        /// <summary>
        /// <para>Start the search and give it two nodes</para>
        /// </summary>
        /// <param name="graps"></param>
        private void BeginSearch(IGraph graps)
        {           
            _search.Start(_graph.Nodes[0], _graph.Nodes[10]);
                          //StartNode     //End Node
        }        

        private void ImagesColouring()
        {
            ConsoleOutput();

            var pathfinderUi = new Ui.PathfinderUi();
        
            pathfinderUi._mapObject = _mapObject;
            pathfinderUi.ResetMap(_graph);

            StartColouringImages(pathfinderUi);
        }

        /// <summary>
        /// <para>Color our path</para>
        /// </summary>
        private void StartColouringImages(Ui.PathfinderUi ui)
        {
            
            foreach (var node in _search.path)
            {
                ui.GetImage(node.NodeID).color = Color.red;
            }
        }

        private void ConsoleOutput()
        {
            print("Search length " + _search.path.Count + "\n");
            print("Iterations " + _search.iterator + "\n");
        }
    }
}