using UnityEngine;
using System.Collections;

public class PowerUpBehaviour : MonoBehaviour {
	
	void OnCollisionEnter2D (Collision2D collision) {
		Destroy (gameObject);
	}

}
