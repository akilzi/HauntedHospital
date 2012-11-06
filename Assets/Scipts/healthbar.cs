using UnityEngine;
using System.Collections;

public class healthbar : MonoBehaviour {
	public Texture hp100,hp90,hp80,hp70,hp60,hp50,hp40,hp30,hp20,hp10,hp00;		//Health bar textures
	GameObject hp_bar;															//Healthbar
	GameObject UI;																//UI folder
	float hp=100;																//Health of the character
	bool death;																	//To check if the character is alive or dead
	// Use this for initialization
	void Awake(){
	//Application.targetFrameRate=60;
	}
		
	void Start () {
	death=false;
	hp_bar=GameObject.Find("hp");												//Healthbar
	hp_bar.guiTexture.texture=hp100;	
	//GUI.Label(100,100,100,100,new Rect(hp100));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
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
	}
	
	void OnGUI() {
	if(hp<0){
		UI=GameObject.Find("UI");
		Destroy(UI);
		death=true;	
		Destroy(GameObject.Find ("Gun_2"));	
		if (GUI.Button(new Rect(Screen.width/2-Screen.width/6, Screen.height/2-Screen.width/20, Screen.width/3, Screen.width/10), "You have died !! Press button to restart !!")) {
			Destroy(GameObject.Find("all"));	
			Application.LoadLevel(0);
			}	
		}
	}
	
	public void damage()
	{
	if(hp>0)
		hp-=8*Time.deltaTime;	
//	print(hp);
	}
	
	public void regen()
	{
	if(hp<100&&death==false)
		hp+=4*Time.deltaTime;	
	}	
}
