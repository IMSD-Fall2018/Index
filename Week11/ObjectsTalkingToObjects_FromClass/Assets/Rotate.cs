using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public float rotateSpeed;

	void Update () {
		this.transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
	}
}
