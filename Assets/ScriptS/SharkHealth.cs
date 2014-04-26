using UnityEngine;
using System.Collections;

public class SharkHealth : MonoBehaviour {
	public int SharkHP = 100;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D collision){
		SharkHP -= 10;
		if (SharkHP == 0){
			Destroy(gameObject);
		}
	}
}
