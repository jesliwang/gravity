using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {
	public Texture background;
	private float width;
	private float height;
	private bool background_music_on;
	public Texture test;
	// Use this for initialization
	void Start (){
		width = Screen.width;
		height = Screen.height;
		
		if(PlayerPrefs.GetInt("background_music") > 0){
			background_music_on = true;
		}else{
			background_music_on = false;
		}
		
	}
	
	void OnGUI (){
		if(Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel(0);
		}
		
		GUI.DrawTexture(new Rect(0, 0, width, height), background, ScaleMode.StretchToFill);
		
		if(background_music_on){
			if(GUI.Button(new Rect(100, 100, 400, 400), test)){
				background_music_on = false;
				PlayerPrefs.SetInt ("background_music", 0);
			}
		}else{
			if(GUI.Button(new Rect(500, 100, 400, 400), test)){
				background_music_on = true;
				PlayerPrefs.SetInt ("background_music", 1);
			}
		}
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
