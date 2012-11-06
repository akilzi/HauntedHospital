using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
	Application.LoadLevel(Application.loadedLevel+1);
	//wait();
	StartCoroutine("wait");	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
	/*if (GUI.Button(new Rect(Screen.width/2-Screen.width/10, Screen.height/2-Screen.width/20, Screen.width/5, Screen.width/10), "Bright Background")) {
		Application.LoadLevel(1);
		}
	if (GUI.Button(new Rect(Screen.width/2-Screen.width/10, Screen.height/3-Screen.width/20, Screen.width/5, Screen.width/10), "Dark Background")) {
		Application.LoadLevel(2);
		}	*/
	
	//if(Time.timeSinceLevelLoad>2f)
	//		Application.LoadLevel(Application.loadedLevel+1);
	}
	
	IEnumerator wait() {
	yield return new WaitForSeconds(1);
	Application.LoadLevel(Application.loadedLevel+1);	
	}
}
