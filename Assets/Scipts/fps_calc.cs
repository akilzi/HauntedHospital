using UnityEngine;
using System.Collections;

public class fps_calc : MonoBehaviour {

	
    float timeA;

    public int fps;

    public int lastFPS;

    public GUIStyle textStyle;

    // Use this for initialization

    void Start () {

        timeA = Time.timeSinceLevelLoad;

        DontDestroyOnLoad (this);

    }

   

    // Update is called once per frame

    void Update () {

        //Debug.Log(Time.timeSinceLevelLoad+" "+timeA);

        if(Time.timeSinceLevelLoad  - timeA <= 1)

        {

            fps++;

        }

        else

        {

            lastFPS = fps + 1;

            timeA = Time.timeSinceLevelLoad;

            fps = 0;

        }

    }

    void OnGUI()

    {

        GUI.Label(new Rect( Screen.width/18, Screen.height-Screen.height/12, 50, 30),""+lastFPS,textStyle);
		//GUI.Label(new Rect( Screen.width/8, Screen.height-Screen.height/12, 50, 30),""+fps,textStyle);

    }
}
