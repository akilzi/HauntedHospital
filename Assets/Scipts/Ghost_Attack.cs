using UnityEngine;
using System.Collections;

public class Ghost_Attack : MonoBehaviour {
	public GameObject target;
	public GameObject light1,light2,bulb;
	public Shader diffuse;
    public Shader vertexlit;
	public healthbar Player_hp;
	// Use this for initialization
	int health;
	void Start () {
	target = GameObject.Find("Character");
	if(target==null)
		target = GameObject.Find("Player");	
	transform.LookAt(target.transform);
	health=75;
	diffuse = Shader.Find("Diffuse");
	vertexlit = Shader.Find("Self-Illumin/VertexLit");	
	light1=GameObject.Find("New_Tube_Light_MeshPart0");
	light2=GameObject.Find("New_Tube_Light_MeshPart1");
	bulb=GameObject.Find("New_Ceiling_lamp");	
	}
	
	// Update is called once per frame
	
	void Update () {
		transform.LookAt(target.transform);
		float dist = Vector3.Distance(target.transform.position, transform.position);
		if(dist<3.1f) {
			Player_hp = target.transform.gameObject.GetComponent("healthbar") as healthbar;
			Player_hp.damage();
		}
		else {
			Player_hp = target.transform.gameObject.GetComponent("healthbar") as healthbar;
			Player_hp.regen();
		}
		if(dist>3f)
			transform.Translate(transform.forward*5*Time.deltaTime,Space.World);
		if(health<0){
			light1.renderer.materials[2].shader=vertexlit;
			light2.renderer.materials[1].shader=vertexlit;
			bulb.renderer.materials[0].shader=vertexlit;
			bulb.renderer.materials[2].shader=vertexlit;
			RenderSettings.ambientLight = new Color(0.3f,0.3f,0.3f,0.5f);
			Destroy(GameObject.Find("alert(Clone)"));
			Destroy(gameObject);
		}
	}
	
	public void damage() {
		health-=6;
		//print (health);
	}	
	
	void OnGUI () {
	
		
	}	
}
