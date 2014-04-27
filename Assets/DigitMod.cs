using UnityEngine;
using System.Collections;
using System.Linq;

public class DigitMod : MonoBehaviour {

	public Sprite One;
	public Sprite Two;
	public Sprite Zero;

	private int LifeRef;
	private int[] twenties;
	private int[] ten;
	private int[] zeros;

	private SpriteRenderer sprite1;

	// Use this for initialization
	void Start () {
		twenties = new int[]{20, 21, 22, 23, 24, 25, 26, 27, 28, 29};
		ten = new int[]{10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
		zeros = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
	}
	
	// Update is called once per frame
	void Update () {
		sprite1 = gameObject.GetComponent<SpriteRenderer>();
		LifeRef = GameObject.Find ("Players").GetComponent<PlayerHealth> ().LifePool;
		if (zeros.Contains(LifeRef)){
			sprite1.sprite = Zero;
		}
		if (ten.Contains(LifeRef)){
			sprite1.sprite = One;
		}
		if (twenties.Contains(LifeRef)){
			sprite1.sprite = Two;
		}
	}
}
