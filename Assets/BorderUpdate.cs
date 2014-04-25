using UnityEngine;
using System.Collections;


public class BorderUpdate : MonoBehaviour {
	public Camera mainCam;
	public BoxCollider2D bottomSide;
	public BoxCollider2D topSide;
	public BoxCollider2D leftSide;
	public BoxCollider2D rightSide;
	// Update is called once per frame
	void Update () {
		topSide.center = new Vector2 ( mainCam.ScreenToWorldPoint (new Vector3 (Screen.width / 2f, 0f, 0f)).x, mainCam.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f);
		bottomSide.center = new Vector2 ( mainCam.ScreenToWorldPoint (new Vector3 (Screen.width * 0.5f, 0f, 0f)).x * 0.1f, mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y - 0.5f);
		leftSide.center = new Vector2 ( mainCam.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x - 0.5f, 0f);
		rightSide.center = new Vector2 ( mainCam.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x + 0.5f, 0f);

	}
}
