using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {
	
	
	void OnGUI () {

		int scrw = Screen.width;
		int scrh = Screen.height;
		
		
		GUI.Box(new Rect(scrw / 2 - scrw / 12,scrh / 2 + scrh / 50,scrw / 6,scrh / 3), "Select Option");
		
		if(GUI.Button(new Rect(scrw / 2 - 40,scrh / 2 + scrh / 10,80,20), "Play")) {
			Application.LoadLevel ("First Level");
		}
		
		if(GUI.Button(new Rect(scrw / 2 - 40,scrh / 2 + 2 * scrh / 10,80,20), "Instruction")) {
			print("Read it and weep");
		}
		
		if(GUI.Button(new Rect(scrw / 2 - 40,scrh / 2 + 3 * scrh / 10,80,20), "Credits")) {
			Application.LoadLevel ("Credits");
		}
		
	}
	
}
