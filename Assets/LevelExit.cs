using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("End") > 0){
			Application.Quit();
		}
		if(Input.GetKeyDown("joystick button 1"))
  {
      Debug.Log("Joystick Button " + "1" + " was pressed!");
  }
	}
}
