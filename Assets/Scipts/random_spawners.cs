using UnityEngine;
using System.Collections;

public class random_spawners : MonoBehaviour {
	float timer;														//Time gap between adjacent spawns
	// Use this for initialization
	public GameObject alert;								//Alert prefabs
	public GameObject ghost;								//Ghost objects
	public GameObject light1,light2,bulb;
	public Shader diffuse;
    public Shader vertexlit;
	bool flicker;
	GameObject detect;
	bool first=true;
	void Start () {
	RenderSettings.ambientLight = new Color(0.5f,0.5f,0.5f,0.4f);	
	diffuse = Shader.Find("Diffuse");
	vertexlit = Shader.Find("Self-Illumin/VertexLit");	
	light1=GameObject.Find("New_Tube_Light_MeshPart0");
	light2=GameObject.Find("New_Tube_Light_MeshPart1");
	bulb=GameObject.Find("New_Ceiling_lamp");	
	timer=Time.timeSinceLevelLoad;
//	spawn();			//Spawns a target at the beginning.. For testing !!!
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	detect=GameObject.Find("alert(Clone)");
	if(first==false)
		if(detect==null)
			time_reset();
	if(timer+Random.Range(10,16)<Time.timeSinceLevelLoad) {
		spawn();
		}
/*	if(flicker==true)
		StartCoroutine("wait");
	else
		flicker=false;	*/
	}
	
	void spawn() {
	first=false;
	ToDark();
	timer=Time.timeSinceLevelLoad+35f;
	Instantiate(alert,new Vector3(0,0,0),Quaternion.identity);
	int b=Random.Range(12,18);
	StartCoroutine("wait");	
	//InvokeRepeating("LaunchProjectile", 2, 0.3F);	
	//Instantiate(ghost,new Vector3(transform.position.x+b,transform.position.y,transform.position.z),Quaternion.identity);
	 print ("Character has passed");
	int a=Random.Range(0,4); 
	if(a==0)	
		Instantiate(ghost,new Vector3(transform.position.x+b,transform.position.y,transform.position.z),Quaternion.identity);	
	else if(a==1)	
		Instantiate(ghost,new Vector3(transform.position.x-b,transform.position.y,transform.position.z),Quaternion.identity);	
	else if(a==2)	
		Instantiate(ghost,new Vector3(transform.position.x,transform.position.y,transform.position.z+b),Quaternion.identity);	
	else if(a==3)	
		Instantiate(ghost,new Vector3(transform.position.x,transform.position.y,transform.position.z-b),Quaternion.identity);

		
	}
	
	void time_reset() {
	timer=Time.timeSinceLevelLoad;
	first=true;	
	}	
	
	void Flicker() {
	flicker=true;	
	}
	
	IEnumerator wait() {
	ToDark();
	yield return new WaitForSeconds(Random.Range(1,3));
	ToBright();
	yield return new WaitForSeconds(1);
	ToDark();
	yield return new WaitForSeconds(Random.Range(1,3));
	ToBright();
	yield return new WaitForSeconds(1);
	ToDark();
	yield return new WaitForSeconds(Random.Range(1,3));
	ToBright();
	yield return new WaitForSeconds(1);
	ToDark();
	yield return new WaitForSeconds(Random.Range(1,3));
	ToBright();
	yield return new WaitForSeconds(1);
	ToDark();
	yield return new WaitForSeconds(Random.Range(1,3));
	ToBright();
	yield return new WaitForSeconds(1);
	ToDark();
	
		
	}
	

	
	void ToDark()
	{
	light1.renderer.materials[2].shader=diffuse;	
	light2.renderer.materials[1].shader=diffuse;
	bulb.renderer.materials[0].shader=diffuse;
	bulb.renderer.materials[2].shader=diffuse;	
	flicker=true;	
	RenderSettings.ambientLight = new Color(0.15f,0.15f,0.15f,0.5f);	
	}
	
	void ToBright(){
		light1.renderer.materials[2].shader=vertexlit;
			light2.renderer.materials[1].shader=vertexlit;
			bulb.renderer.materials[0].shader=vertexlit;
			bulb.renderer.materials[2].shader=vertexlit;
		RenderSettings.ambientLight = new Color(0.5f,0.5f,0.5f,0.5f);
	}	
}