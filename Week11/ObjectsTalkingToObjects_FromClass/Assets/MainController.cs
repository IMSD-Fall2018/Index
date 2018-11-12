using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

	public Rotate rotatescript;
	public Spawner spawnerscript;

	public SimpleMove movescript;

	public GameObject cylindertoinvis_obj;
	public MeshRenderer cylindertoinvis_rend;

	public AudioSource musictoplay;

	public Camera camtocontrol;
	public Color backColor;

	public TextMesh textObj;

	void Start () {
		textObj.text = "";
		textObj.fontSize = 50;
	}

	float textTimer = 0;
	void Update () {
		RotationControl();
		SpawnerControl();
		MoveControl();
		CylinderControl();
		MusicControl();
		CamBackgroundControl();

		textTimer += Time.deltaTime;
		if (textTimer > 5f) {
			textObj.text = "Hello World";
			textTimer = 0;
		}
	}


	bool backgroundFlag = true;
	void CamBackgroundControl() {
		if (Input.GetKeyDown(KeyCode.Alpha6) && backgroundFlag == false) {
			camtocontrol.backgroundColor = backColor;
			backgroundFlag = true;
		} else if (Input.GetKeyDown(KeyCode.Alpha6) && backgroundFlag == true) {
			//make random color
			Color randColor = new Color();
			randColor.r = Random.Range(0, 1f);
			randColor.b = Random.Range(0, 1f);
			randColor.g = Random.Range(0, 1f);

			camtocontrol.backgroundColor = randColor;
			backgroundFlag = false;
		}
	}



	void MusicControl() {
		if (Input.GetKeyDown(KeyCode.Alpha5) && musictoplay.isPlaying == false) {
			musictoplay.Play();
		} else if (Input.GetKeyDown(KeyCode.Alpha5) && musictoplay.isPlaying == true) {
			musictoplay.Stop();
		}
	}

	void CylinderControl() {
		//if (Input.GetKeyDown(KeyCode.Alpha4) && cylindertoinvis_obj.activeSelf == true) {
		//	cylindertoinvis_obj.SetActive(false);
		//} else if (Input.GetKeyDown(KeyCode.Alpha4) && cylindertoinvis_obj.activeSelf == false) {
		//	cylindertoinvis_obj.SetActive(true);
		//}
		if (Input.GetKeyDown(KeyCode.Alpha4) && cylindertoinvis_rend.enabled == true) {
			cylindertoinvis_rend.enabled = false;
		} else if (Input.GetKeyDown(KeyCode.Alpha4) && cylindertoinvis_rend.enabled == false) {
			cylindertoinvis_rend.enabled = true;
		}
	}


	void RotationControl() {
		//Rotate Cube Control
		if (Input.GetKeyDown(KeyCode.Alpha1) && rotatescript.rotateSpeed == 0f) {
			rotatescript.rotateSpeed = 180f;
		} else if (Input.GetKeyDown(KeyCode.Alpha1) && rotatescript.rotateSpeed >= 1f) {
			rotatescript.rotateSpeed = 0f;
		}
	}

	void SpawnerControl() {
		// spawn control
		if (Input.GetKeyDown(KeyCode.Alpha2)) {
			spawnerscript.SpawnObject();
		}
	}

	void MoveControl() {
		//Move Control
		if (Input.GetKeyDown(KeyCode.Alpha3) && movescript.moveSpeed <= 0f) {
			movescript.moveSpeed = 4f;
		} else if (Input.GetKeyDown(KeyCode.Alpha3) && movescript.moveSpeed != 0f) {
			movescript.moveSpeed = -4f;
		}


	}


}
