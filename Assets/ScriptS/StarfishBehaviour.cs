using UnityEngine;
using System.Collections;

public class StarfishBehaviour : MonoBehaviour {

	public float speed;
	// public float force;

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

	void Update () {

			target = FindClosest();
			transform.LookAt(target.transform);
			transform.position = Vector2.MoveTowards((Vector2) transform.position, 
		                                         (Vector2) target.transform.position, speed);
	
	}
}
