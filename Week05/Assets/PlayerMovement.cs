using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float movementSpeed = 1f;
	Vector3 newPosition = Vector3.zero;

	void Start () {
		newPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey(KeyCode.UpArrow)){
		newPosition.y += (Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
		newPosition.x += (Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime);
		
		this.transform.position = newPosition;


	}
}
