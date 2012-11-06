using UnityEngine;
using System.Collections;

public class alert_align : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	guiTexture.pixelInset=new Rect(Screen.width/2-Screen.height/26,Screen.height-Screen.height/12,Screen.height/13,Screen.height/13);	//Display an alert icon at the top of the screen whenever the ghost spawns
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
