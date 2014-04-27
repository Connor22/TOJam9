using UnityEngine;
using System.Collections;

public class CrateBehaviour : MonoBehaviour {

	public GameObject LifeUp;
	public GameObject PowerUp;

	private int drop;


	// Use this for initialization
	void Start () {
		drop = Random.Range (1, 5);
	}

	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag != "Enemy"){
			if (drop == 5){
				Instantiate(LifeUp, transform.position, transform.rotation);
			} else {
				Instantiate(PowerUp, transform.position, transform.rotation);
			}
		}
		Destroy (gameObject);
	}
}
