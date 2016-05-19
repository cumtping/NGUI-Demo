using UnityEngine;
using System.Collections;

public class HelpPanelCloseButton : MonoBehaviour {
	public GameObject helpPanelObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick(){
		iTween.MoveTo(helpPanelObj, new Vector3(-Screen.width / 2, Screen.height / 2, 0), 1);
	}
}
