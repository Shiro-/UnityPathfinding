using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //Create a grid for our test
        int[,] map = new int[5, 5]
        {
            {0, 1, 0, 0, 0},
            {0, 1, 0, 0, 0},
            {0, 1, 1, 0, 0},
            {0, 1, 0, 0, 0},
            {0, 0, 0, 0, 0}
        };

        //Create a graph to hold our map data
        var graph = new Graph(map);
        //Create a search for the graph
        var search = new Search(graph);

        //Start the search and give it two nodes
        search.Start(graph.nodes[0], graph.nodes[2]);

        //Step through each solution
        while(!search.isDone)
        {
            search.Step();
        }

        //Output
        print("Search length" + search.path.Count + "\n");
        print("Iterartions" + search.iter + "\n");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
