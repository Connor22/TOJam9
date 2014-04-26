using UnityEngine;
using System.Collections;

public class ExplosionBehaviour : MonoBehaviour {

	public float lifetime = 3f;

	private float remainingLifetime;

	// Use this for initialization
	void Start () {
		remainingLifetime = lifetime;
	}
	
	// Update is called once per frame
	void Update () {
		remainingLifetime -= Time.deltaTime;

		if (remainingLifetime < 0) {
			Destroy(gameObject);
		}
	}
}
