using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2(speed, 0f); 
	}
	
	// Update is called once per frame

	void OnCollisionEnter2D(Collision2D collision){
		Destroy(gameObject);
	}
}
