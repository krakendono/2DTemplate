using UnityEngine;
using System.Collections;

public class DialogButton : MonoBehaviour {
	
	public GameObject dialog;
	
	// Use this for initialization
	void Start () {
		dialog = GameObject.Find ("Menu");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Tap () {
		if(dialog.GetComponent<Dialog>().open){
			dialog.GetComponent<Dialog>().CloseDialog();
		}
		else{
			dialog.GetComponent<Dialog>().OpenDialog();
		}
	}
}
