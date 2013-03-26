using UnityEngine;
using System.Collections;

public class BackGroundMusic : MonoBehaviour{
	public AudioSource music;
	public static BackGroundMusic Instance{
		get{
			if(_instance == null){
				_instance = GameObject.FindObjectOfType(typeof(BackGroundMusic)) as BackGroundMusic;
				if(!_instance){
					GameObject container = new GameObject();
					container.name = "BackGroundMusicSingleton";
					_instance = container.AddComponent(typeof(BackGroundMusic)) as BackGroundMusic;
					DontDestroyOnLoad(container);
				}
			}
			return _instance;
		}
	}
	private static BackGroundMusic _instance;
	
	
	public void Play(){
		if( !music.isPlaying ){
			music.Play();
			music.volume = 1.0f;
		}
	}
	
	public void Stop(){
		if( music.isPlaying ){
			music.Stop();
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
