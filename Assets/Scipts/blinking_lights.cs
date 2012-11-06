using UnityEngine;
using System.Collections;

public class blinking_lights : MonoBehaviour {
	//Vector4 bright= new Color(60,60,60,100);
	//Vector4 dark= new Color(20,20,20,10);
	// Use this for initialization
	
	public GameObject light1;			//Tubelights on the sides
	public Shader diffuse;				//Normal shader type
    public Shader vertexlit;			//Vertexlit shader type
	
	void Start () {
	diffuse = Shader.Find("Diffuse");		//Shader used in normal surfaces
	vertexlit = Shader.Find("Self-Illumin/VertexLit");	//Shader used in light emitting objects
	light1=GameObject.Find("New_Tube_Light_MeshPart0");		//Tubelight objects
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if(light1.renderer.materials[2].shader==vertexlit)
			RenderSettings.ambientLight = new Color(0.3f,0.3f,0.3f,0.5f);		//Makes the environment brighter
	else if(light1.renderer.materials[2].shader==diffuse)
			RenderSettings.ambientLight = new Color(0.07f,0.07f,0.07f,0.3f);	//Makes the environment darker
	
	}
	
	void flicker() {
		
	}	
	
	
	
}
