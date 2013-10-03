using UnityEngine;
using System.Collections;

public class MuteButton : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Tap () {
		if(AudioListener.volume == 0){
			AudioListener.volume = 1;
			renderer.material.mainTextureOffset = new Vector2(0, 0.5F);
		}
		else{
			AudioListener.volume = 0;
			renderer.material.mainTextureOffset = new Vector2(0, 0);
		}
	}
}
