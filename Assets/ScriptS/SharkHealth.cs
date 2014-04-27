using UnityEngine;
using System.Collections;

public class SharkHealth : MonoBehaviour {

	public float SharkHPMax = 100;
	public Texture2D LifeBarFull;
	public Texture2D LifeBarHurt;
	public Texture2D Shark1;
	public float SharkHPCur;
	public float divider;
	public int invincible;


	private PlayerHealth LifeRef;
	private float LifeWidth;
	private float height;
	private float invCounter;

	// Use this for initialization
	void Start () {
		SharkHPCur = SharkHPMax;
		invCounter = -1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (invCounter > -1){
			if (invCounter > invincible){
				renderer.enabled = true;
				invCounter = -1f;
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
		if (collision.gameObject.tag != "Bounds" && invCounter == -1) {
			if (collision.gameObject.tag != "Super"){
				SharkHPCur -= 10;
			} else {
				SharkHPCur -= 20;
			}
			invCounter = 0f;
			LifeRef = GameObject.Find ("Players").GetComponent<PlayerHealth> ();
			if (SharkHPCur == 0.0) {
					if (LifeRef.PlayerCount == 0) {
							Application.LoadLevel ("Draw Screen");
					} else {
							Application.LoadLevel ("Sheep Win");
					}
					}
			}
		}


	void OnGUI(){
		height = Screen.height / divider;
		GUI.DrawTexture (new Rect (10f, 10f, Screen.width / 4, height), LifeBarHurt, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect (10f, 10f, Screen.width / 4 / (SharkHPMax / SharkHPCur), height), LifeBarFull, ScaleMode.StretchToFill);
		GUI.DrawTexture (new Rect (Screen.width / 4 + 15f, 10f, height, height), Shark1, ScaleMode.ScaleToFit);
	}
}
