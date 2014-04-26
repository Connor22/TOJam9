using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {
	
	
	void OnGUI () {
		
		int scrw = Screen.width;
		int scrh = Screen.height;
		
		
		GUI.Box(new Rect(scrw / 2 - scrw / 12,scrh / 2 + scrh / 30,scrw / 6,scrh / 3 + scrh / 10), "Select Option");
		
		if(GUI.Button(new Rect(scrw / 2 - scrw / 16,scrh / 2 + scrh / 8,scrw / 8,scrw / 30), "Play")) {
			Application.LoadLevel ("First Level");
		}
		
		if(GUI.Button(new Rect(scrw / 2 - scrw / 16,scrh / 2 + 2 * scrh / 8,scrw / 8,scrw / 30), "Instruction")) {
			print("Read it and weep");
		}
		
		if(GUI.Button(new Rect(scrw / 2 - scrw / 16,scrh / 2 + 3 * scrh / 8,scrw / 8,scrw / 30), "Credits")) {
			Application.LoadLevel ("Credits");
		}

	}
	
}