using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTestScript : MonoBehaviour {

	public float testfloat = 2f;
	public float[] testfloatarray;
	public Vector3[] spawnpoints = new Vector3[50];
	public float[] testfloatarray2 = new float[40];
	//public Color[] colorlist;
	//public GameObject[] objs;
	
	void Start () {
		testfloatarray = new float[50];
		//An array of length 50, that goes from 70 to 119
		for (int i = 0; i < 50; i++) {
			testfloatarray[i] = (float)(i + 70);
		}
		//new array, of length 40, that goes from 0 to 80 (in steps of 2). 
		int j = 0;
		for (int i = 0; i < 40; i++) {
			testfloatarray2[i] = (float)(j);
			j += 2;
		}
		for (int i = 0; i < testfloatarray2.Length; i++) {
			Debug.Log(testfloatarray2[i]);
		}


		Debug.Log(testfloatarray2);



	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
