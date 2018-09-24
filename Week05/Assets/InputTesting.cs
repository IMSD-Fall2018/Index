using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTesting : MonoBehaviour {

	public Spawner spawnerscript;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKeyDown("space")) {
			//Debug.Log("Input is working!");
			spawnerscript.SpawnObject(this.transform.position);

		}

	}
}
