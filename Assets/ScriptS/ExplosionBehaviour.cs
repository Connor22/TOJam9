using UnityEngine;
using System.Collections;

public class ExplosionBehaviour : MonoBehaviour {

	public float lifetime = 3f;
	public float blastLifetime = 0.5f;

	private float remainingLifetime;
	private bool blastPresent = true;

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

		if (blastPresent && ((remainingLifetime + blastLifetime) < lifetime)) {
			// blast lifetime has expired
			Destroy(rigidbody2D);
		}
	}
}
