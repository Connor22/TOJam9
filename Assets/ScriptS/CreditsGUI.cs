using UnityEngine;
using System.Collections;

public class CreditsGUI : MonoBehaviour {

	void OnGUI () {
		
		if(GUI.Button(new Rect(Screen.width / 2 - 40,320,80,20), "Back")) {
			Application.LoadLevel ("Menu");
		}
		
	}
}
