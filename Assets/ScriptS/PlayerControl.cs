using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float force = 100f;
	public float spawnPos;
	public string HorizontalName;
	public string VerticalName;
	public string Fire;
	public GameObject Bullet;
	public GameObject Super;
	public GameObject Self;
	public GameObject OtherP;
	public int SetBulletDelay;
	public int invincible;
	public int powerTime;


	private Vector3 CurrentPos;
	private int BulletTime = 0;
	private float newPos;
	private PlayerHealth Parent;
	private SharkHealth SharkRef;
	private float invCounter;
	private float powerCounter;
	private int speed;
	private Animator anim;

	// Use this for initialization
	void Start () {
		newPos = Random.Range (-9.0f, 9.0f);
		transform.position = new Vector2 (spawnPos, newPos);
		invCounter = -1f;
		powerCounter = -1f;
		speed = 1;
		anim = gameObject.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if (powerCounter > -1){
			if (powerCounter > powerTime){
				powerCounter = -1f;
				speed = 1;
				anim.SetBool("isPower", false);
			} else {
				powerCounter += Time.deltaTime;
			}
		}
		rigidbody2D.AddForce(new Vector2(speed * force * Input.GetAxis(HorizontalName), 
		                                 speed * force * Input.GetAxis(VerticalName)));
		CurrentPos = new Vector3(transform.position.x - 1.5f, transform.position.y - 0.5f);
		if (BulletTime > 0) {
			BulletTime -= 1;
		}
		if (Input.GetAxis (Fire) > 0 && BulletTime == 0){
			if (powerCounter > -1) {
				Instantiate(Super, CurrentPos, transform.rotation);
			} else {
				Instantiate(Bullet, CurrentPos, transform.rotation);
			}
			BulletTime = SetBulletDelay;
		}
		if (invCounter > -1){
			gameObject.layer = 13;
			if (invCounter > invincible){
				renderer.enabled = true;
				invCounter = -1f;
				gameObject.layer = 8;
			} else if (renderer.enabled == true){
				renderer.enabled = false;
				invCounter += Time.deltaTime;
			} else {
				renderer.enabled = true;
				invCounter += Time.deltaTime;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Power") {
			powerCounter = 0f;
			speed = 2;
			anim.SetBool("isPower", true);
		}
		if (collision.gameObject.tag == "1Up") {
			Parent = transform.parent.GetComponent<PlayerHealth>();
			Parent.LifePool += 1;
			if(Parent.PlayerCount == 1){
				newPos = Random.Range (-9.0f, 9.0f);
				Instantiate(OtherP, new Vector3 (spawnPos, newPos, 0f), transform.rotation);
				Parent.PlayerCount += 1;
			}
		}
		if (collision.gameObject.tag == "Enemy" && invCounter == -1) {
			newPos = Random.Range (-9.0f, 9.0f);
			Parent = transform.parent.GetComponent<PlayerHealth>();
			SharkRef = GameObject.Find("Shark").GetComponent<SharkHealth>();
			if (Parent.LifePool > 0) {
				transform.position = new Vector2 (spawnPos, newPos);
				Parent.LifePool -= 1;
				invCounter = 0f;
			} else {
				Parent.PlayerCount -= 1;
				if(Parent.PlayerCount > 0){
					Destroy(gameObject);
				}
				else {
					if (SharkRef.SharkHPCur == 0){
						Application.LoadLevel ("Draw Screen");
					} else {
						Application.LoadLevel ("Shark Win");
					}
				}
			}
		}
	}
}
