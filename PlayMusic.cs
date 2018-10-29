using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {
    AudioSource myaudio;

	// Use this for initialization
	void Start () {
        myaudio = this.gameObject.GetComponent<AudioSource>();



	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            
            myaudio.Play();

            myaudio.pitch = Random.Range(.7f, 1.4f);
        }
	}
}
