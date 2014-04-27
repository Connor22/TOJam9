using UnityEngine;
using System.Collections;

public class SharkControl : MonoBehaviour {

	public float force = 100.0F;

	public GameObject Torpedo;
	public float torpedoCost = 5.0f;

	public GameObject Bomb;
	public float bombCost = 10.0f;
	public float bombForce = 50.0f;

	public GameObject Follow;
	public float followCost = 30.0f;
	public float followForce = 75.0f;

	public GameObject Sin;
	public float sinCost = 15.0f;

	public float energy = 100f;
	public float maximumEnergy = 200f;
	public float energyPerSecond = 5f;

	public int SetBulletDelay;

	public Texture2D EnergyFull;
	public Texture2D EnergyEmpty;
	public Texture2D LIGHTNING;
	public float divider;

	private float height;
	private Animator anim;
	
	private Vector3 BulletPos;
	private int BulletTime = 0;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}

	void FixedUpdate () {
		// movement
		rigidbody2D.AddForce (new Vector2 (0f, force * Input.GetAxis ("P3Vertical")));
		anim.SetBool("Fire", false);
		// energy tracking
		energy += Time.deltaTime * energyPerSecond;
		if (energy > maximumEnergy) {
			energy = maximumEnergy;
		}

		// firing
		BulletPos = new Vector3(transform.position.x + 3.5f, transform.position.y - 1.5f);
		if (BulletTime > 0) {
			BulletTime -= 1;
		}

		if ((BulletTime == 0) && (energy >= torpedoCost) && (Input.GetAxis("SharkFireTorpedo") > 0)) {
			Instantiate(Torpedo, BulletPos, transform.rotation);
			energy -= torpedoCost;
			BulletTime = SetBulletDelay;

			anim.SetBool("Fire", true);
		}
		if ((BulletTime == 0) && (energy >= bombCost) && (Input.GetAxis("SharkFireBomb") > 0)) {
			GameObject bomb = Instantiate(Bomb, BulletPos, transform.rotation) as GameObject;
			bomb.rigidbody2D.AddForce(new Vector2(bombForce + Random.Range(-bombForce * 0.2f, bombForce * 0.2f), 0f)); // throw bomb with some force variance
			bomb.GetComponent<BombBehaviour>().canExplode = true;

			energy -= bombCost;
			BulletTime = SetBulletDelay;

			anim.SetBool("Fire", true);
		}

		if ((BulletTime == 0) && (energy >= sinCost) && (Input.GetAxis("SharkFireSin") > 0)) {
			Instantiate(Sin, BulletPos, transform.rotation);

			energy -= sinCost;
			BulletTime = SetBulletDelay;

			anim.SetBool("Fire", true);
		}

		if ((BulletTime == 0) && (energy >= followCost) && (Input.GetAxis("SharkFireFollow") > 0)) {
			GameObject follow = Instantiate(Follow, BulletPos, transform.rotation) as GameObject;
			follow.rigidbody2D.AddForce(new Vector2(followForce, 0f));

			energy -= followCost;
			BulletTime = SetBulletDelay;

			anim.SetBool("Fire", true);
		}
		// end firing
	}

	void OnGUI(){
		height = Screen.height / divider;
		GUI.DrawTexture (new Rect (10f, Screen.height - height - 10f, Screen.width / 4, height), EnergyEmpty, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect (10f, Screen.height - height - 10f, Screen.width / 4 / (maximumEnergy / energy), height), EnergyFull, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect (Screen.width / 4 + 20f, Screen.height - height - 10f, height / 2, height), LIGHTNING, ScaleMode.StretchToFill);
	}
}