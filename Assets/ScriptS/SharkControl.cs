using UnityEngine;
using System.Collections;

public class SharkControl : MonoBehaviour {

	public float force = 100.0F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.AddForce(new Vector2(0f, force * Input.GetAxis("P3Vertical")));
		if (rigidbody2D.velocity.x > 0){
			rigidbody2D.velocity = new Vector2 (0f, rigidbody2D.velocity.x);
		}
	}
}