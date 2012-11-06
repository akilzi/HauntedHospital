using UnityEngine;
using System.Collections;

public class key_spawn : MonoBehaviour {
	public GameObject key;
	// Use this for initialization
	void Start () {
	spawn();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.collider.name=="key_collider(Clone)"||other.collider.name=="key_collider")
		{
		spawn();
		}
	}
	
	
	public void spawn() {
	int choice=Random.Range(1,6);
	if(choice==1)
		spawn1();
	else if(choice==2)
		spawn2();
	else if(choice==3)
		spawn3();
	else if(choice==4)
		spawn4();
	else if(choice==5)
		spawn5();
	else if(choice==6)
		spawn6();	
	}
	
	public void spawn1() {
	float x=-17.5f;
	float y= 0.5f;
	float z=Random.Range(-102f,102f);	
	Object.Instantiate(key, new Vector3(x,y,z), Quaternion.Euler(0,90,0));
	}
	public void spawn2() {
	float x=97f;
	float y= 0.5f;
	float z=Random.Range(-102f,102f);	
	Object.Instantiate(key, new Vector3(x,y,z), Quaternion.Euler(0,90,0));
	}
	public void spawn3() {
	float x=Random.Range(-16,97);
	float y= 0.5f;
	float z=104f;	
	Object.Instantiate(key, new Vector3(x,y,z), Quaternion.identity);
	}
	public void spawn4() {
	float x=Random.Range(-16,97);
	float y= 0.5f;
	float z=53f;	
	Object.Instantiate(key, new Vector3(x,y,z), Quaternion.identity);
	}
	public void spawn5() {
	float x=Random.Range(-16,97);
	float y= 0.5f;
	float z=-53f;	
	Object.Instantiate(key, new Vector3(x,y,z), Quaternion.identity);
	}
	public void spawn6() {
	float x=Random.Range(-16,97);
	float y= 0.5f;
	float z=-104f;	
	Object.Instantiate(key, new Vector3(x,y,z), Quaternion.identity);
	}
		
}
