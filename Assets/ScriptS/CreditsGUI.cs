using UnityEngine;
using System.Collections;

public class CreditsGUI : MonoBehaviour {

	void OnGUI () {

		int scrw = Screen.width;
		int scrh = Screen.height;
		
		if(GUI.Button(new Rect(scrw / 2 - scrw / 16,scrh / 2 + 3 * scrh / 8,scrw / 8,scrw / 30), "Back")) {
			Application.LoadLevel ("Menu");
		}
		
	}
}
