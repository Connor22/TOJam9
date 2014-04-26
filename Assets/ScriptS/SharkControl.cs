using UnityEngine;
using System.Collections;

public class SharkControl : MonoBehaviour {

	public float force = 100.0F;
	public float bombForce = 50.0f;
	public GameObject Torpedo;
	public GameObject Bomb;
	public int SetBulletDelay;

	private Vector3 BulletPos;
	private int BulletTime = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		// movement
		rigidbody2D.AddForce (new Vector2 (0f, force * Input.GetAxis ("P3Vertical")));

		// firing
		BulletPos = new Vector3(transform.position.x + 7f, transform.position.y);
		if (BulletTime > 0) {
			BulletTime -= 1;
		}

		if ((BulletTime == 0) && (Input.GetAxis("SharkFireTorpedo") > 0)) {
			Instantiate(Torpedo, BulletPos, transform.rotation);

			BulletTime = SetBulletDelay;
		}
		if ((BulletTime == 0) && (Input.GetAxis("SharkFireBomb") > 0)) {
			GameObject bomb = Instantiate(Bomb, BulletPos, transform.rotation) as GameObject;
			bomb.rigidbody2D.AddForce(new Vector2(bombForce, 0f));
			bomb.GetComponent<BombBehaviour>().canExplode = true;

			BulletTime = SetBulletDelay;
		}
		// end firing
	}
}