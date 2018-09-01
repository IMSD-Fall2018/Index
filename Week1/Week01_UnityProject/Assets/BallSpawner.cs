using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballToSpawn;

	// Use this for initialization
	void Start () {
		
	}

	float spawnTimer = 0;
	void Update () {
		spawnTimer += 1f;
		if (spawnTimer > 120f) {
			GameObject.Instantiate(ballToSpawn);
			spawnTimer = 0;
		}
	}
}
