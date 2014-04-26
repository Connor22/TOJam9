using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float force = 100f;
	public string HorizontalName;
	public string VerticalName;
	public string Fire;
	public GameObject Bullet;
	public Vector3 CurrentPos;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		rigidbody2D.AddForce(new Vector2(force * Input.GetAxis(HorizontalName), force * Input.GetAxis(VerticalName)));
		CurrentPos = new Vector3(transform.position.x - 5f, transform.position.y);
		if (Input.GetAxis (Fire) > 0){
			Instantiate(Bullet, CurrentPos, transform.rotation); 
		}
	}
}
