using UnityEngine;
using System.Collections;

public class SharkHealth : MonoBehaviour {

	public int SharkHP = 100;

	private PlayerHealth LifeRef;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D collision){
		SharkHP -= 10;
		LifeRef = GameObject.Find("Players").GetComponent<PlayerHealth>();
		if (SharkHP == 0){
			if(LifeRef.PlayerCount == 0){
				Application.LoadLevel ("Draw Screen");
			} else {
				Application.LoadLevel ("Sheep Win");
			}
		}
	}
}
