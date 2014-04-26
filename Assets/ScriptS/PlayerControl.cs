using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float force = 100f;
	public string HorizontalName;
	public string VerticalName;
	public string Fire;
	public GameObject Bullet;
	public GameObject Self;
	public int SetBulletDelay;

	private Vector3 CurrentPos;
	private int BulletTime = 0;
	private float newPos;
	private PlayerHealth Parent;

	// Use this for initialization
	void Start () {
		newPos = Random.Range (-9.0f, 9.0f);
		transform.position = new Vector2 (18.0f, newPos);
	}

	// Update is called once per frame
	void Update () {
		rigidbody2D.AddForce(new Vector2(force * Input.GetAxis(HorizontalName), force * Input.GetAxis(VerticalName)));
		CurrentPos = new Vector3(transform.position.x - 1.5f, transform.position.y - 0.5f);
		if (BulletTime > 0) {
			BulletTime -= 1;
				}
		if (Input.GetAxis (Fire) > 0 && BulletTime == 0){
			Instantiate(Bullet, CurrentPos, transform.rotation); 
			BulletTime = SetBulletDelay;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Enemy") {
			newPos = Random.Range (-9.0f, 9.0f);
			Parent = transform.parent.GetComponent<PlayerHealth>();
			if (Parent.LifePool > 0) {
				transform.position = new Vector2 (18.0f, newPos);
				Parent.LifePool -= 1;
			}
			else{
				Destroy(gameObject);
			}
		}
	}
}
