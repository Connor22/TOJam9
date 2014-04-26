using UnityEngine;
using System.Collections;

public class BombBehaviour : MonoBehaviour {

	public GameObject explosion;
	public bool canExplode = false;
	
	// Update is called once per frame
	void Update () {
		if (rigidbody2D.velocity.magnitude < 0.01f) {
			// explode on stop
			Explode();
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		Explode();
	}

	// Explodes the fish.
	void Explode() {
		if (canExplode) {
			Instantiate(explosion, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}
