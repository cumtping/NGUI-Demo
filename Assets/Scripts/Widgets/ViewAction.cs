using UnityEngine;
using System.Collections;

public class ViewAction : MonoBehaviour {
	public AudioSource bgMusic;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void musicSwitch(bool newValue) {
		if (newValue) {
			bgMusic.Play ();
		} else {
			bgMusic.Stop ();
		}
	}

	public void musicVolume(float newValue) {
		bgMusic.volume = newValue;
	}
}
