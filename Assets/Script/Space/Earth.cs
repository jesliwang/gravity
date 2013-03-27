using UnityEngine;
using System.Collections;

public class Earth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void OnGUI () {
		if(Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel(0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, Time.deltaTime*30, 0);
		transform.RotateAround(new Vector3(0, 1, 0), new Vector3(0, 0, Time.deltaTime*0.1f), 0.05f);
	}
}
