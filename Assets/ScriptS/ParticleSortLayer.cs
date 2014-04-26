using UnityEngine;
using System.Collections;

public class ParticleSortLayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// This places the particle system on the correct sorting layer, since this 
		// isn't settable in the Inspector
		particleSystem.renderer.sortingLayerName = "Foreground";
	}
}
