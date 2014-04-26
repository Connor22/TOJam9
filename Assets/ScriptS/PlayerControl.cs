using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float force = 100f;
	public string HorizontalName;
	public string VerticalName;
	public string Fire;
	public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.AddForce(new Vector2(force * Input.GetAxis(HorizontalName), force * Input.GetAxis(VerticalName)));

		if (Input.GetAxis (Fire) > 0){
			Instantiate(Bullet); 
		}
	}
}
