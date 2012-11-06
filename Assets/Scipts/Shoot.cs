using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	public GameObject blood;
	public GameObject miss;
	public GameObject flash;
	public Ghost_Attack attack;
	// Use this for initialization
	GameObject gun;
	public Texture btn_shoot;
	void Start () {
	gun=GameObject.Find("flash_point");
	Input.multiTouchEnabled=true; 	
	}
	 
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI () {        
		int size=Screen.height/10;
		if (GUI.Button(new Rect(Screen.width/2+2*Screen.width/5-size/2,Screen.height/2+Screen.height/6-size/2,Screen.height/10,Screen.height/10),btn_shoot,"label"))
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
		
		}
	
	}	
}
