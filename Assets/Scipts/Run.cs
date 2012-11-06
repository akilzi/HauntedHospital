using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour {
	public Texture hp100,hp90,hp80,hp70,hp60,hp50,hp40,hp30,hp20,hp10,hp00,run_on,run_off;	//Textures used to display stamina and run nd walk button
	public GameObject character;		//Character
	GameObject hp_bar;					//Stamina bar
	GameObject btn_run;					//Run-Walk button
	float hp;							//Stamina level
	float timer;						//Timegap between buttons
	bool power=true,move;				//To check if the movement is run or walk, and to check if the character is moving or not
	// Use this for initialization
	void Start () {
	hp=100.0f;							//Stamina of the character
	timer=2f;	
	character=GameObject.Find("Character");
	hp_bar=GameObject.Find("run_bar");	//Stamina bar
	btn_run=GameObject.Find("btn_run");	//Run-Walk button
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	timer+=0.1f;
	if(hp>90)
		hp_bar.guiTexture.texture=hp100;	
	else if(hp<90&&hp>80)
		hp_bar.guiTexture.texture=hp90;
	else if(hp<80&&hp>70)
		hp_bar.guiTexture.texture=hp80;
	else if(hp<70&&hp>60)
		hp_bar.guiTexture.texture=hp70;	
	else if(hp<60&&hp>50)
		hp_bar.guiTexture.texture=hp60;
	else if(hp<50&&hp>40)
		hp_bar.guiTexture.texture=hp50;
	else if(hp<40&&hp>30)
		hp_bar.guiTexture.texture=hp40;	
	else if(hp<30&&hp>20)
		hp_bar.guiTexture.texture=hp30;
	else if(hp<20&&hp>10)
		hp_bar.guiTexture.texture=hp20;
	else if(hp<10&hp>5)
		hp_bar.guiTexture.texture=hp10;	
	else if(hp<5)
		hp_bar.guiTexture.texture=hp00;	
		
	if(hp<0)
		{	
		character.SendMessage ("walk");
		power=false;
		}	
		
	if(power==true)
		{
		if(move==true)	
			hp-=0.1f;
		btn_run.guiTexture.texture=run_on;	
		character.SendMessage ("Run");	
	//	Light.light.enabled=true;		
		}
	else 
		{
		character.SendMessage ("walk");
		btn_run.guiTexture.texture=run_off;		
	//	Light.light.enabled=false;		
		}
		
	if(move==false||power==false)
		if(hp<100)	
			hp+=0.25f;	
		
	}
	
	
	void run_start(){
	move=true;	
	}
	
	void run_stop(){
	move=false;	
	}
	
	void OnGUI () { 
	/*	if(power==true)
		{
		if(GUI.Button(new Rect(100,100,100,100),run_off,"label")){	
				power=false;
			}	
		}	
		if(power==false)
		{
		if(GUI.Button(new Rect(100,100,100,100),run_on,"label")){	
				power=true;
			}	
		}
		*/
		
		int i = 0;
        while (i < Input.touchCount) {
        if (Input.GetTouch(i).phase == TouchPhase.Began) {
        
		if(btn_run.guiTexture.HitTest(Input.GetTouch(i).position)&&timer>1f)
			{	
			timer=0f;		
			if(power==true)
				power=false;
			else if(power==false)
				power=true;		
					
			//print ("POWER = " + power);
			}
		}	
		++i;
        }
	}
}
