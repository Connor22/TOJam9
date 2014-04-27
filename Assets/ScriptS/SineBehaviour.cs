using UnityEngine;
using System.Collections;

public class SineBehaviour : MonoBehaviour {

	public float speed; // Set to 0.1
	public float amplitude; // Set to 2
	public float period; // Set to 3

	float originalY;
	Vector3 newPosition;

	void Start () {
		originalY = transform.position.y + 0.5f;

	}

	void Update () {

		newPosition = new Vector3(transform.position.x + speed * 0.1f, 
		                          amplitude * (originalY + Mathf.Sin (transform.position.x * period)), 0f);
		transform.localPosition = newPosition;

	}

	void OnCollisionEnter2D (Collision2D collision) {
		Destroy (gameObject);
	}
}
