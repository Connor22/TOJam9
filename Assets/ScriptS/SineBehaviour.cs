using UnityEngine;
using System.Collections;

public class SineBehaviour : MonoBehaviour {

	public float speed; // Set to 0.1
	public float amplitude; // Set to 2

	float originalY;
	float originalX;
	Vector3 newPosition;

	void Start () {
		originalX = transform.position.x;
		originalY = transform.position.y;

	}

	void Update () {

		newPosition = new Vector3(transform.position.x + speed, 
		                          amplitude * (originalY + 
		                          Mathf.Sin (transform.position.x - originalX)), 0f);
		transform.position = newPosition;

	}

	void OnCollisionEnter2D (Collision2D collision) {
		Destroy (gameObject);
	}
}
