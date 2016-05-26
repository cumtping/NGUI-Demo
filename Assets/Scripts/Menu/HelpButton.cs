using UnityEngine;
using System.Collections;

public class HelpButton : MonoBehaviour {

	public GameObject helpPanelObj;
	//public AudioClip clickSound;
	public AudioSource clickSoundSource;

	// Use this for initialization
	void Start () {
		Debug.Log("Start!!!");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Update!!!");
	}

	public void OnClick(){
		iTween.MoveTo(helpPanelObj, new Vector3(Screen.width / 2, Screen.height / 2, 0), 1);
		//AudioSource.PlayClipAtPoint (clickSound, transform.localPosition);

		clickSoundSource.Play ();
	}
}
