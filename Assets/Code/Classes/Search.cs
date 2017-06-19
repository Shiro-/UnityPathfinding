using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Pathfinding.Core
{
    class Search
    {
        //Reference to a graph
        public IGraph graph;

        //Keep track of our nodes
        public List<Node> possible;
        public List<Node> visited;
        public List<Node> path;
        //End goal
        public Node endNode;
        //Keep track of our iterations
        public int iterator;
        //Check if the search is done
        public bool isDone;

        //Search class
        public Search(IGraph graph)
        {
            this.graph = graph;
        }

        //Start for indicating our start and end
        public void Start(Node start, Node end)
        {
            //Create a list for nodes possible
            possible = new List<Node>();
            //The starting point will always be reachable
            possible.Add(start);

            //Set the end node to be the end
            endNode = end;

            //Keep track of all nodes visited
            visited = new List<Node>();
            //Keep track of our path
            path = new List<Node>();
            //Reset iterations
            iterator = 0;

            //Go through the graph and clear out the nodes
            for (var i = 0; i < graph.Nodes.Length; i++)
            {
                //Get the node and clear it
                graph.Nodes[i].ClearNode();
            }
        }

        /// <summary>
        /// <para>Test the nodes</para>
        /// </summary>
        public void Step()
        {
            //If we have a path, leave
            if (path.Count > 0)
            {
                return;
            }

            //No more options
            if (possible.Count == 0)
            {
                isDone = true;
                return;
            }

            iterator++;

            //Pick a node
            var node = ChooseNode();
            //Check if the node we picked is the goal node
            if (node == endNode)
            {
                //Go back over our nodes to find the path
                while (node != null)
                {
                    path.Insert(0, node);
                    node = node.PreviusNode;
                }

                //Exit
                isDone = true;
                return;
            }

            //Remove the node from the list
            possible.Remove(node);
            //Add it to our visited list
            visited.Add(node);

            //Iterate through adj nodes
            for (var i = 0; i < node.Nodes.Count; i++)
            {
                addAdj(node, node.Nodes[i]);
            }
        }

        //Populate solution
        public void addAdj(Node node, Node adj)
        {
            if (findNode(adj, visited) || findNode(adj, possible))
            {
                return;
            }

            //Add current node to adj node previouse field
            adj.PreviusNode = node;
            //Add to reachable list
            possible.Add(adj);
        }

        //Finding the next node
        public bool findNode(Node node, List<Node> list)
        {
            return getIndex(node, list) >= 0;
        }

        //Get the index of a node
        public int getIndex(Node node, List<Node> list)
        {
            //Check if node exists in the list
            for (var i = 0; i < list.Count; i++)
            {
                //Check if the node is equal to a node in the list
                if (node == list[i])
                {
                    return i;
                }
            }

            return -1;
        }

        //Pick a node
        //Normally, nodes will be weighted so we can choose the best possible path
        //In this case, we will grab a random node from the list

        //Here is the problem (TODO: WORK!) if you fix this you win
        public Node ChooseNode()
        {
            return possible[Random.Range(0, possible.Count)];
        }
    }
}