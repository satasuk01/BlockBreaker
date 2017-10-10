using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//unitypatterns.com/singletons/ (a class that made for only 1 instance???)
//in this class is that we want only 1 bgmusic and make sure that unity won't duplicate it when we move to the next scence and get back.
//gameprogrammingoatterns.com

//music will created then Awake method will start first next is Start method and the last is update
//if we put awake in start it may cause a little glitch (because Awake()and Start() have a time gap)
public class musicPlayer : MonoBehaviour {
	static musicPlayer instance = null;

	void Awake() { //put int awake will make music flow stimutaneously
		Debug.Log ("Music player Awake " + GetInstanceID ());
		if (instance != null) { //prevent new musicplayer is created(If another scene has music player or move back to start menu)
			Destroy (gameObject);
			Debug.Log ("Duplicate music player self-destructing!");//make new music get destroy before run start
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
			Debug.Log ("Music created!!!");
		}
	}
	// Use this for initialization
	void Start () {
		Debug.Log ("Music player Start "+ GetInstanceID());
		}
	// Update is called once per frame
	void Update () {
		
	}

}

