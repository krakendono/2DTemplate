using UnityEngine;
using System.Collections;

public class CloseDialog : MonoBehaviour {
	
	void Tap () {
		transform.parent.GetComponent<Dialog>().CloseDialog();
	}
}
