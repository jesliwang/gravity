using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
	public Texture MyRound;
	// Use this for initialization
	private float x;
	private float y;
	private float width;
	private float height;
	void Start () {
		x = 0;
		y = 0;
		
		width = Screen.width - MyRound.width;
		height = Screen.height - MyRound.height;
	}
	
	void OnGUI () {
		string tmp = "Position is";
		tmp += x;
		tmp += " ";
		tmp += y;
		GUI.Label(new Rect(0,0,100,30), tmp);
		
		GUI.DrawTexture(new Rect(x, y, 200, 200), MyRound);
		
		if(Application.platform == RuntimePlatform.Android){
			if(Input.GetKeyDown(KeyCode.Escape)){
				Application.LoadLevel(0);
			}else if(Input.GetKeyDown(KeyCode.Home)){
				
			}
		}
	}
	// Update is called once per frame
	void Update () {
		x += Input.acceleration.x * 10.0f;
		y += -Input.acceleration.y * 10.0f;
		if(0 > x){
			x = 0;
		}else if(x > width){
			x = width;
		}
		
		if(0 > y){
			y = 0;
		}else if( y > height){
			y = height;
		}
	}
}
