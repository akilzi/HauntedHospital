using UnityEngine;
using System.Collections;

public class Ghost_Spawn : MonoBehaviour {
public GameObject smoke;
public GameObject alert;
	int a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
        print ("Character has passed");
		a=Random.Range(0,3);
		Instantiate(alert,new Vector3(0,0,0),Quaternion.identity);
		if(a<1.5)
			Instantiate(smoke,transform.position+transform.right*10f-transform.up*1.1f,transform.rotation);
		else if(a>1.4)
			Instantiate(smoke,transform.position-(transform.right*10f-transform.up*1.1f),transform.rotation);
		
		//Destroy(gameObject);
	}
}
