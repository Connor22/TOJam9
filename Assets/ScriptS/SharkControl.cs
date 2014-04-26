using UnityEngine;
using System.Collections;

public class SharkControl : MonoBehaviour {

	public float force = 100.0F;
	public GameObject Bullet;
	public string Fire;
	public int SetBulletDelay;

	private Vector3 CurrentPos;
	private int BulletTime = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
				rigidbody2D.AddForce (new Vector2 (0f, force * Input.GetAxis ("P3Vertical")));
		        CurrentPos = new Vector3(transform.position.x + 7f, transform.position.y);
				if (BulletTime > 0) {
						BulletTime -= 1;
				}
				if (Input.GetAxis (Fire) > 0 && BulletTime == 0) {
						Instantiate (Bullet, CurrentPos, transform.rotation); 
						BulletTime = SetBulletDelay;
				}
		}
	}
