using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject spawn;

	public void SpawnObject(Vector3 spawnPosition) {
			GameObject child = Instantiate(spawn, spawnPosition, Quaternion.identity);
	}

}
