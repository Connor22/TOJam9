using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	public string LevelName;
	void OnMouseDown() {
		Application.LoadLevel(LevelName);
	}
}
