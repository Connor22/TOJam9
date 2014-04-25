using UnityEngine;
using System.Collections;

public class GuiTest : MonoBehaviour {


	void OnGUI () {


		GUI.Box(new Rect(Screen.width / 2 - 50,210,100,140), "Select Option");

		if(GUI.Button(new Rect(Screen.width / 2 - 40,240,80,20), "Play")) {
			print("Aw hell naw");
		}

		if(GUI.Button(new Rect(Screen.width / 2 - 40,280,80,20), "Instruction")) {
			print("Read it and weep");
		}

		if(GUI.Button(new Rect(Screen.width / 2 - 40,320,80,20), "Credits")) {
			print("It's all me");
		}

	}

}
