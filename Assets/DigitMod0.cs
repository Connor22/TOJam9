using UnityEngine;
using System.Collections;
using System.Linq;

public class DigitMod0 : MonoBehaviour {

	public Sprite One;
	public Sprite Two;
	public Sprite Three;
	public Sprite Four;
	public Sprite Five;
	public Sprite Six;
	public Sprite Seven;
	public Sprite Eight;
	public Sprite Nine;
	public Sprite Zero;

	private int LifeRef;
	private int[] ones;
	private int[] twos;
	private int[] threes;
	private int[] fours;
	private int[] fives;
	private int[] sixes;
	private int[] sevens;
	private int[] eights;
	private int[] nines;
	private int[] zeros;

	private SpriteRenderer sprite1;

	// Use this for initialization
	void Start () {
		zeros = new int[]{0, 10, 20};
		ones = new int[]{1, 11, 21};
	    twos = new int[]{2, 12, 22};
	    threes = new int[]{3, 13, 23};
	    fours = new int[]{4, 14, 24};
	    fives = new int[]{5, 15, 25};
	    sixes = new int[]{6, 16, 26};
	    sevens = new int[]{7, 17, 27};
	    eights = new int[]{8, 18, 28};
	    nines = new int[]{9, 19, 29};
	}
	
	// Update is called once per frame
	void Update () {
		sprite1 = gameObject.GetComponent<SpriteRenderer>();
		LifeRef = GameObject.Find ("Players").GetComponent<PlayerHealth> ().LifePool;
		if (zeros.Contains(LifeRef)){
			sprite1.sprite = Zero;
		}
		if (twos.Contains(LifeRef)){
			sprite1.sprite = Two;
		}
		if (ones.Contains(LifeRef)){
			sprite1.sprite = One;
		}
		if (threes.Contains(LifeRef)){
			sprite1.sprite = Three;
		}
		if (fours.Contains(LifeRef)){
			sprite1.sprite = Four;
		}
		if (fives.Contains(LifeRef)){
			sprite1.sprite = Five;
		}
		if (sixes.Contains(LifeRef)){
			sprite1.sprite = Six;
		}
		if (sevens.Contains(LifeRef)){
			sprite1.sprite = Seven;
		}
		if (eights.Contains(LifeRef)){
			sprite1.sprite = Eight;
		}
		if (nines.Contains(LifeRef)){
			sprite1.sprite = Nine;
		}
		


	}
}