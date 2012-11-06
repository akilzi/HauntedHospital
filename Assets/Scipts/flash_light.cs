using UnityEngine;
using System.Collections;

public class flash_light : MonoBehaviour {
	public Texture hp100,hp90,hp80,hp70,hp60,hp50,hp40,hp30,hp20,hp10,hp00,light_switch_on,light_switch_off;	//Batterymeter textures and flashlight button textures
	public GameObject light;	//Tubelights at the sides
	GameObject hp_bar;			//Healthbar
	GameObject btn_flash;		//Flashlight button
	float hp;					//Battery level of the flash light
	float timer;				//Time gap between flash light button can be pressed
	bool power;					//Boolean to check if the power of the flash light is turned on or off
	// Use this for initialization
	void Start () {
	hp=100;
		//power=true;
	light=GameObject.Find("flashlight");			//Flashlight
	hp_bar=GameObject.Find("flash_bar");			//Flashlight battery meter
	btn_flash=GameObject.Find("btn_flash");			//Flashlight button
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
	if(hp<1)
		light.light.enabled=false;	
		
		
	if(power==true&&hp>0)
		{
		hp-=0.015f;
		btn_flash.guiTexture.texture=light_switch_on;	
		light.light.enabled=true;	
	//	Light.light.enabled=true;		
		}
	else 
		{
		light.light.enabled=false;
		btn_flash.guiTexture.texture=light_switch_off;		
	//	Light.light.enabled=false;		
		}
	}
	
	
	void OnGUI () {       
		
		int i = 0;
        while (i < Input.touchCount) {
        if (Input.GetTouch(i).phase == TouchPhase.Began) {
        
		if(btn_flash.guiTexture.HitTest(Input.GetTouch(i).position)&&timer>1f)
			{
			timer=0f;		
			if(power==true)
				power=false;
			else if(power==false)
				power=true;		
					
					
			}
		}	
		++i;
        }
	}
}
