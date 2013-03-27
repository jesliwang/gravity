using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {
	public Texture background;
	public Texture playButton;
	private float width;
	private float height;
	private BackGroundMusic music;

	// Use this for initialization
	void Start () {
		width = Screen.width;
		height = Screen.height;
		music = BackGroundMusic.Instance;
		
		if(PlayerPrefs.GetInt("background_music") > 0){
			music.Play();
		}else{
			music.Stop();
		}
	}
			
	void OnGUI () {
		if(Application.platform == RuntimePlatform.Android && Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
		
		GUI.DrawTexture(new Rect(0,0, width, height), background, ScaleMode.StretchToFill);
		if(GUI.Button(new Rect(width/2.0f, height/2.0f, 100, 100), playButton)){
			Application.LoadLevelAdditive(1);
		}
		
		if(GUI.Button(new Rect(width/2.0f, height/2.0f+ 150f, 100, 100), playButton)){
			Application.LoadLevel(2);
		}
		
		if(GUI.Button(new Rect(width/2.0f, height/2.0f+ 300f, 100, 100), "Space")){
			Application.LoadLevel(3);
		}
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
}
