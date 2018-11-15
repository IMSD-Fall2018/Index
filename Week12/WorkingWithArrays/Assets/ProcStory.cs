using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcStory : MonoBehaviour {

	public string[] beginnings;
	public string[] protagonists;
	public string[] places;

	void Start () {
		string finalstory = "";
		finalstory += beginnings[Random.Range(0, beginnings.Length)];
		finalstory += ", ";
		finalstory += "there was a ";
		finalstory += protagonists[Random.Range(0, protagonists.Length)];
		finalstory += " who lived ";
		finalstory += places[Random.Range(0, places.Length)];
		finalstory += ".";
		Debug.Log(finalstory);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
