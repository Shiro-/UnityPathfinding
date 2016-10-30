using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Test : MonoBehaviour {

    public GameObject map;

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

        resetMap(graph);

        //Color our path
        foreach(var node in search.path)
        {
            getImage(node.lbl).color = Color.red;
        }
    }

    //Get image of the game object
    Image getImage(string lbl)
    {
        //Convert the label into a number
        var id = Int32.Parse(lbl);
        //Get a reference to the game object
        var go = map.transform.GetChild(id).gameObject;

        //Return the image component
        return go.GetComponent<Image>();
    }

    //Reset colors of the map
    void resetMap(Graph graph)
    {
        //For each node in our graph
        foreach(var node in graph.nodes)
        {
            //Check if the node is open or solid
            //Open is grey
            //Solid is white
            getImage(node.lbl).color = node.adj.Count == 0 ? Color.white : Color.gray;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
