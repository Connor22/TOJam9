using UnityEngine;
using System.Collections;

public class SineBehaviour2 : MonoBehaviour {

	private float originalY;
	private float currentRange;
	public float amplitude;
	public float speed;
	public float appliedForce;



	void Start(){
		float randomfl = Random.Range(0.5f, 1.5f);
		originalY = transform.position.y;
	}

	void Update() {
		currentRange = Mathf.Sin (originalY + amplitude * Time.time);
		if (currentRange > 0) {
			rigidbody2D.AddForce(new Vector2(0f, appliedForce));		
		}
		if (currentRange < 0) {
			rigidbody2D.AddForce (new Vector2 (0f, -appliedForce));	
		} 
		else {
			rigidbody2D.velocity = new Vector2 (speed, 0f);	
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		Destroy (gameObject);
	}
}
