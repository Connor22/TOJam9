using UnityEngine;
using System.Collections;

public class PowerUpDrop : MonoBehaviour {

	public int dropRate;
	public GameObject Crate;
	
	private int powerUp;

	void Start(){
		powerUp = Random.Range (0, dropRate);
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (powerUp > (dropRate - 5) && collision.gameObject.tag == "Bullet" && 
		    transform.position.x > 0){
			Instantiate(Crate, transform.position, transform.rotation);
		}
	}
}