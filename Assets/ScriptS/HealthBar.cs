using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	private SharkHealth SharkRef;
	private int fullHP;
	private Vector3 origSize;
	private Vector3 newSize;

	// Use this for initialization
	void Start () {
		origSize = transform.localScale;
		SharkRef = GameObject.Find("Shark").GetComponent<SharkHealth>();
		fullHP = SharkRef.SharkHP;
	}
	
	// Update is called once per frame
	void Update () {
	
		SharkRef = GameObject.Find("Shark").GetComponent<SharkHealth>();
		newSize = new Vector3 (origSize.x * SharkRef.SharkHP / fullHP, origSize.y, 0f);
		transform.localScale = newSize;
	
	}
}
