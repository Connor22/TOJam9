using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour {
	//Top Banner
	float topBannerH;
	float topBannerW;
	//Buttons
	float buttonSizeH;
	float buttonSizeW;
	float buttonPos1;
	float buttonPos2;
	float buttonPos3;
	float buttonPos4;
	float buttonPos5;
	//Bottom Banner
	float bottomBannerH;
	float bottomBannerW;
	float bottomBannerPos;
	string exampleVar1;
	GUISkin customSkin1;
	GUISkin customSkin2;
	GUISkin customSkin3;
	public Texture2D Play;
	public Texture2D Instructions;
	public Texture2D Credits;
	public float Offset1;
	public float Offset2;




	void Update () {	
		topBannerH = Screen.height / 4;
		topBannerW = Screen.width;
		buttonSizeH = Screen.height/10;
		buttonSizeW = Screen.width;
		buttonPos1 = topBannerH;
		buttonPos2 = topBannerH + buttonSizeH * Offset1;
		buttonPos3 = topBannerH + buttonSizeH * Offset2;
		bottomBannerH = Screen.height/4;
		bottomBannerW = Screen.width;
		bottomBannerPos = topBannerH + buttonSizeH*5;	
	}
	
	void OnGUI () {		
		if (GUI.Button(new Rect(0,buttonPos1,buttonSizeW,buttonSizeH), Play)){
			Application.LoadLevel ("First Level");
		}
		//Button 2
		if (GUI.Button(new Rect(0,buttonPos2,buttonSizeW,buttonSizeH), Instructions)){
			print("Read it and weep");
		}
		//Button 3
		if (GUI.Button(new Rect(0,buttonPos3,buttonSizeW,buttonSizeH),Credits)){
			Application.LoadLevel ("Credits");;
		}
	}
	
}