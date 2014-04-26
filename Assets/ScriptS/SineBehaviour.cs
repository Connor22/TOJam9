using UnityEngine;
using System.Collections;

public class SineBehaviour : MonoBehaviour {

	public float speed; // Set to 0.1
	public float amplitude; // Set to 2
	public float period; // Set to 3

	float originalY;
	Vector3 newPosition;

	void Start () {
		originalY = transform.position.y;

	}

	void Update () {

		newPosition = new Vector3(transform.position.x + speed, 
		                          amplitude * (originalY + Mathf.Sin (Time.time * period)), 0f);
		transform.position = newPosition;

	}

	void OnCollisionEnter2D (Collision2D collision) {
		Destroy (gameObject);
	}
}
