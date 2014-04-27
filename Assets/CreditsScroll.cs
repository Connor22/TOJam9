using UnityEngine;
using System.Collections;

public class CreditsScroll : MonoBehaviour {
	public float timeElapsed;
	public float waitTime;
	public float stopTime;
	public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timeElapsed += Time.deltaTime;
		if (timeElapsed > waitTime){
			rigidbody2D.velocity = new Vector2 (0f, speed);
		}
		if (timeElapsed > stopTime){
			rigidbody2D.velocity = new Vector2 (0f, 0f);
		}
	}
}
