using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {


	Vector3 initialForce;

	// Use this for initialization
	void Start () {
		initialForce.x = Random.Range(-5000f, 5000f);
		initialForce.z = Random.Range(-5000f, 5000f);

		GetComponent<Rigidbody>().AddForce(initialForce);

	}
	
	// Update is called once per frame
	void Update () {
		
	}



	
}
