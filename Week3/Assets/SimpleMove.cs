using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {

	public float moveSpeed;

	void Update() {
		this.transform.Translate(Vector3.up * Time.deltaTime);
	}
}
