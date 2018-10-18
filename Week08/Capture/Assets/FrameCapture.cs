using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameCapture : MonoBehaviour {

	public string folderName = "Screenshots";
	public int frameRate = 30;
	private int frameNum = 0;

	// Use this for initialization
	void Start () {
		System.IO.Directory.CreateDirectory(folderName);
		Time.captureFramerate = frameRate;
	}
	
	// Update is called once per frame
	void Update () {
		string fileName = string.Format("{0}/frame{1:D04}.png", folderName, frameNum);
		Debug.Log(fileName);
		ScreenCapture.CaptureScreenshot(fileName);
		frameNum++;
	}
}
