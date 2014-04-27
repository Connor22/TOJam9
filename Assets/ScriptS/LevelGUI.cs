using UnityEngine;
using System.Collections;

public class LevelGUI : MonoBehaviour {

	public int healthBarGUIHeight = 32;
	public int healthBarGUIWidth = 128;

	private SharkHealth sharkHealthRef;
	private int fullHP;
	private GameObject healthBarRef;
	private Vector3 healthBarFullSize;

	public int energyBarGUIHeight = 32;
	public int energyBarGUIWidth = 128;

	private SharkControl sharkControlRef;
	private float fullEnergy;
	private GameObject energyBarRef;
	private Vector3 energyBarFullSize;

	private PlayerHealth playerHealthRef;
	private int fullLives;

	// Use this for initialization
	void Start () {
		sharkHealthRef = GameObject.Find("Shark").GetComponent<SharkHealth>();
		fullHP = sharkHealthRef.SharkHP;
		healthBarRef = GameObject.Find("Health Bar Foreground");
		healthBarFullSize = healthBarRef.transform.localScale;

		sharkControlRef = sharkHealthRef.GetComponent<SharkControl>();
		fullEnergy = sharkControlRef.maximumEnergy;
		energyBarRef = GameObject.Find("Energy Bar Foreground");
		energyBarFullSize = energyBarRef.transform.localScale;

		playerHealthRef = GameObject.Find("Players").GetComponent<PlayerHealth>();
		fullLives = playerHealthRef.LifePool;
	}
	
	void OnGUI () {
		int currentHP = sharkHealthRef.SharkHP;
		float currentEnergy = sharkControlRef.energy;
		int currentLives = playerHealthRef.LifePool;

		// size the foregrounds appropriately
		healthBarRef.transform.localScale = new Vector3(healthBarFullSize.x * ((float)currentHP / (float)fullHP), healthBarFullSize.y);
		energyBarRef.transform.localScale = new Vector3(energyBarFullSize.x * (currentEnergy / fullEnergy), energyBarFullSize.y);

		// show numbers
		GUI.Box(new Rect(0, 0, (float)healthBarGUIWidth, (float)healthBarGUIHeight), 
		        currentHP.ToString() + " / " + fullHP.ToString() + " Health"); // health at the top left
		GUI.Box(new Rect(0, Screen.height - energyBarGUIHeight, (float)energyBarGUIWidth, (float)energyBarGUIHeight), 
		        currentEnergy.ToString("####") + " / " + fullEnergy.ToString("####") + " Energy"); // energy at the bottom left
		GUI.Box(new Rect(Screen.width - healthBarGUIWidth, 0, (float)healthBarGUIWidth, (float)healthBarGUIHeight), 
		        currentLives.ToString() + " / " + fullLives.ToString() + " Lives"); // lives at the top right
	}
}
