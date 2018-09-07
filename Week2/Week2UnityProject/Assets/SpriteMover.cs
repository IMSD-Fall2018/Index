using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour {

	public float moveDistance;
	public float moveSpeed;
	public Vector3 newPosition;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		newPosition.y = moveDistance * Mathf.Sin(moveSpeed * Time.time);
		this.transform.position = newPosition;
	}
}
