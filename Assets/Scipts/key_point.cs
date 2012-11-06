using UnityEngine;
using System.Collections;

public class key_point : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerExit(Collider other) {
       if(other.collider.name=="Character")
		Destroy(gameObject);
			//spawn();
	}
	
	public void spawn() {
	float x=Random.Range(-16,97);
	float y= 0.5f;
	float z=-53f;	
	transform.position= new Vector3(x,y,z);
	}
}
