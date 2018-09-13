using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject spawn;
	public float initialDelay = 0;
	public float repeatRate = 1f;
	int numberSpawned = 0;
	public float randDist = 2f;
	void Start () {
		InvokeRepeating("SpawnObject", initialDelay, repeatRate);
	}
	void Update () {
	}
	void SpawnObject() {
		if (numberSpawned < 50) {
			Vector3 spawnPosition;
			Vector3 spawnOffset;
			spawnOffset = new Vector3(Random.Range(-randDist, randDist), Random.Range(-randDist, randDist), 0);
			//spawnPosition = this.transform.position;
			spawnPosition = this.transform.position + spawnOffset;

			GameObject child = Instantiate(spawn, spawnPosition, Quaternion.identity);
			child.name = "RotatorClone" + numberSpawned;
			child.GetComponent<Rotate>().rotateSpeed = Random.Range(-200f, 200f);
			numberSpawned++;
		}
	}

}
