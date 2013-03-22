using UnityEngine;
using System.Collections;

public class gravity : MonoBehaviour {
	private float width;
	private float height;
	// Use this for initialization
	void Start () {
		width = Screen.width;
		height = Screen.height;
		
	}
	
	void OnGUI () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(-width/2.0 <= transform.position.x && transform.position.x + 5 < width/2.0 && -height/2.0 <= transform.position.z && transform.position.z + 5< height/2.0){
			transform.Translate(Input.acceleration.x*Time.deltaTime*0.01f, 0, Input.acceleration.z*Time.deltaTime*0.001f);
			//transform.Translate(0.001f, 0, 0);
		}	
		
	}
}
