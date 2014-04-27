using UnityEngine;
using System.Collections;

public class StarfishBehaviour : MonoBehaviour {

	//public float speed;
	public float force;

	private GameObject target;
	
	void Start () {
	
	}

	GameObject FindClosest(){

		GameObject[] players;
		players = GameObject.FindGameObjectsWithTag ("Player");
		GameObject closest = null;
		float closestDistance = Mathf.Infinity;
		Vector2 position = (Vector2) transform.position;
		foreach (GameObject p in players) {
			Vector2 diff = (Vector2) p.transform.position - position;
			float currDistance = diff.sqrMagnitude;
			if (currDistance < closestDistance) {
					closestDistance = currDistance;
					closest = p;
			}
		}
		return closest;

	}

	void FixedUpdate () {

		target = FindClosest();

		// look at target
		Quaternion rotation = new Quaternion();
		transform.LookAt(target.transform);
		rotation.SetLookRotation(Vector3.forward, Vector3.up);
		transform.localRotation = rotation;

		// accelerate towards target
		Vector2 targetDirection = new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y);
		targetDirection.Normalize();
		rigidbody2D.AddForce(targetDirection * force);
	}

	void OnCollisionEnter2D (Collision2D collision) {
		Destroy (gameObject);
	}
}
