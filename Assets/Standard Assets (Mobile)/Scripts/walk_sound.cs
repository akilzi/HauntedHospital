using UnityEngine;
using System.Collections;

public class walk_sound : MonoBehaviour {
	public GameObject moveTouchPad;
	
	// Use this for initialization
	bool test,move_start=true;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
/*	if(moveTouchPad.position.x==0&&moveTouchPad.position.y==0) {
	if(move_start==true)
				StartCoroutine("play_audio");		
			//StartCoroutine(play_audio()); 
	//print("position zero");
	test=false;
	}
	else {
	move_start=false;
	audio.Stop();
	test=true;
		
	
	}	*/
	}
	
	void OnGUI() {
	if(test==true)
		GUI.Label(new Rect(Screen.width/2,Screen.height/2,Screen.width/2,Screen.height/2),"Joystick Moved");
	}

	IEnumerator play_audio() {
	move_start=false;
	//audio.clip=move;
	//audio.volume=1f;		
	audio.Play();
	yield return new WaitForSeconds (3);

	move_start=true;
//	move_start=false;
	
	}
	
}
