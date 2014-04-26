using UnityEngine;
using System.Collections;

public class SharkControl : MonoBehaviour {
	
	public GameObject Shark;
	public float speed = 10.0F;
	public float force = 100.0F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.AddForce(new Vector2(0f, force * Input.GetAxis("P3Vertical")));
	}
}