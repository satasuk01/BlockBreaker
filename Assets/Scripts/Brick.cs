using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public int maxHits;
	private int hitCount;
	//public LevelManager levelmanager;//not use find method cause new version don't need it
	private LevelManager levelmanager;
	//-----------------
	void OnCollisionEnter2D(Collision2D collision){ //when something hit it
		//Debug.Log(this.ToString+" get hit!!!");
		hitCount++;
		if(hitCount >= maxHits) {
			Destroy (gameObject); //don't use this(it'll destroy all bricks)
		}
		//Debug.Log(hitCount);
	}
	//----------------

	// Use this for initialization
	void Start () {
		hitCount = 0;
		levelmanager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//TODO remove this method oncec we can actually win!
	void SimulateWin(){
		levelmanager.loadNextLevel ();
	}
}
