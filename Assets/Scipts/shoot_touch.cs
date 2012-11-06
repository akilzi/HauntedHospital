using UnityEngine;
using System.Collections;

public class shoot_touch : MonoBehaviour {
	public GameObject blood;	//Blood prefab
	public GameObject miss;		//Bullet missed prefab
	public GameObject flash;	//Muzzle flash prefab
	public Ghost_Attack attack;	//Ghost attacking script
	//public AudioClip footsteps;
//	public AudioClip shoot;
	// Use this for initialization
	GameObject gun;				
	GameObject btn_shoot;		//Button to shoot
	bool move_start=true;
	
	void Start () {
	gun=GameObject.Find("flash_point");
	btn_shoot=GameObject.Find("btn_shoot");
	//a=true;	
		
	}
	 
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {        
		/*
		int i = 0;
        while (i < Input.touchCount) {
		if(btn_shoot.guiTexture.HitTest(Input.GetTouch(i).position))
		{
		if(a==true)
		{
		Ray ray = Camera.main.ScreenPointToRay( new Vector3(Screen.width/2,Screen.height/2,0) );
		RaycastHit hit;
		Instantiate(flash,gun.transform.position,gun.transform.rotation);
		if( Physics.Raycast( ray, out hit, 10000 ) )
				{
               	print( hit.transform.gameObject.name );
				}                        
       
		if(hit.transform.gameObject.name == "doctor(Clone)"||hit.transform.gameObject.name == "doc1(Clone)")
				{
				Instantiate(blood,hit.point,Quaternion.identity);
				attack = hit.transform.gameObject.GetComponent("Ghost_Attack") as Ghost_Attack;
				attack.damage();	
				}
		else if(hit.transform.gameObject.name != "doctor(Clone)"&&hit.transform.gameObject.name != "doc1(Clone)")
				{
				Instantiate(miss,hit.point,Quaternion.identity);
				}	
		b=Time.timeSinceLevelLoad;
		a=false;			
		}
		}		
		++i;
		}
		reload();	*/
		
		
		int i = 0;
        while (i < Input.touchCount) {
        if (Input.GetTouch(i).phase == TouchPhase.Began) {
        
		if(btn_shoot.guiTexture.HitTest(Input.GetTouch(i).position))
		{
	//	audio.clip=shoot;			
		//audio.PlayOneShot(shoot);		
		audio.Play(); 		
		Ray ray = Camera.main.ScreenPointToRay( new Vector3(Screen.width/2,Screen.height/2,0) );
		RaycastHit hit;
		Instantiate(flash,gun.transform.position,gun.transform.rotation);
		if( Physics.Raycast( ray, out hit, 10000 ) )
				{
               	//print( hit.transform.gameObject.name );doctor_mist
						
				}                        
       
		if(hit.transform.gameObject.name == "doctor(Clone)"||hit.transform.gameObject.name == "doc1(Clone)"||hit.transform.gameObject.name == "doctor_mist(Clone)")
				{
				Instantiate(blood,hit.point,Quaternion.identity);
				attack = hit.transform.gameObject.GetComponent("Ghost_Attack") as Ghost_Attack;
				attack.damage();	
				}
		else if(hit.transform.gameObject.name != "doctor(Clone)"&&hit.transform.gameObject.name != "doc1(Clone)"||hit.transform.gameObject.name != "doctor_mist(Clone)")
				{
				Instantiate(miss,hit.point,Quaternion.identity);
				}
            }
			}	
            ++i;
        }
	}
/*	
IEnumerator play_audio()
{
move_start=false;	
audio.volume=0.6f;	
audio.Play();
audio.volume=1f;		
//yield return new WaitForSeconds (1);
move_start=true;
//	move_start=false;
	
} */


	
}