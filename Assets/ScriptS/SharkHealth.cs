using UnityEngine;
using System.Collections;

public class SharkHealth : MonoBehaviour {
	public float SharkHPMax = 100;
	public Texture2D LifeBarFull;
	public Texture2D LifeBarHurt;
	public Texture2D Shark1;
	public float SharkHPCur;
	public float divider;


	private PlayerHealth LifeRef;
	private float LifeWidth;
	private float height;

	// Use this for initialization
	void Start () {
		SharkHPCur = SharkHPMax;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D collision){
		SharkHPCur -= 10;
		LifeRef = GameObject.Find("Players").GetComponent<PlayerHealth>();
		if (SharkHPCur == 0.0){
			if(LifeRef.PlayerCount == 0){
				Application.LoadLevel ("Draw Screen");
			} else {
				Application.LoadLevel ("Sheep Win");
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
