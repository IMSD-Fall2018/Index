using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotTaker : MonoBehaviour {

	public string fileName = "screenshot.png";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.S)){
			Debug.Log("screenshot taken");
			ScreenCapture.CaptureScreenshot(fileName);
		}
	}
}
