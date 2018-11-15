using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringTest : MonoBehaviour {

	public string[] messages;
	public string firstname = "Alexander";
	public string lastname = "King";
	public string[] names;

	// Use this for initialization
	void Start () {
		//for (int i = 0; i < messages.Length; i++) {
		//	Debug.Log(messages[i]);
		//}

		Debug.Log(messages[Random.Range(0, messages.Length)]);
		Debug.Log(firstname + " " + lastname);

		//Debug.Log(messages[Random.Range(0, messages.Length)] + ", " + names[Random.Range(0, names.Length)] +"!");
		string finalstory = "";
		finalstory += messages[Random.Range(0, messages.Length)];
		finalstory += ", ";
		finalstory += names[Random.Range(0, names.Length)];
		finalstory += "!";
		Debug.Log(finalstory);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
