using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	void Start () {
	
	}
		
	void Update () {
		if (Input.GetKey(KeyCode.Escape)) {
			backToMenu ();
		}
	}

	public void backToMenu() {
		Application.LoadLevel (0);
	}
}
