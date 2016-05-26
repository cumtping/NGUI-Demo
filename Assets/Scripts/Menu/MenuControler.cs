using UnityEngine;
using System.Collections;

public class MenuControler : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape)) {
			// Quit game
			quitGame();
		}
	}

	public void quitGame() {
		Application.Quit();
	}
}
