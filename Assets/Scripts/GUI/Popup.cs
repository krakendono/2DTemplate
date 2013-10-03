using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {
	
	private TextMesh thisTextMesh;
	
	// Use this for initialization
	void Start () {
		thisTextMesh.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		if(thisTextMesh.color.a > 0){
			thisTextMesh.color = new Color(thisTextMesh.color.r, thisTextMesh.color.g, thisTextMesh.color.b, thisTextMesh.color.a - 0.05F);
		}
	}
	
	public void Appear (string text) {
		thisTextMesh.color = new Color(thisTextMesh.color.r, thisTextMesh.color.g, thisTextMesh.color.b, 1);
		thisTextMesh.text = text;
	}
}
