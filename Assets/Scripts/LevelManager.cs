using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void loadLevel(string name){
		Debug.Log ("Clicked Level load requested for : "+name);
		Application.LoadLevel (name);
	}
	public void quitRequest(){
		Debug.Log ("Requested for quit");
		Application.Quit();
	}
}