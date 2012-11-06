using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Awake() {
        Application.targetFrameRate = 60;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {
	 if (GUI.Button(new Rect(10, 70, 50, 30), "Exit"))		//Creates a button to exit the game
			Application.Quit();
	if (GUI.Button(new Rect(10, 130, 50, 30), "Pause"))		//Creates a button to pause the game
		if(Time.timeScale==1)	
			Time.timeScale=0;
		else
			Time.timeScale=1;
		
	}	
}
