using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	
	public Sprite[] hitSprites;

	private int maxHits;
	private int hitCount;
	//public LevelManager levelmanager;//not use find method cause new version don't need it
	private LevelManager levelmanager;
	//-----------------
	void OnCollisionEnter2D(Collision2D collision){ //when something hit it
		bool isBreakable = (this.tag == "Breakable");
		if (isBreakable) handleHits();
	}

	void handleHits(){
		//Debug.Log(this.ToString+" get hit!!!");
		hitCount++;
		maxHits = hitSprites.Length + 1;
		if (hitCount >= maxHits) {
			Destroy (gameObject); //don't use this(it'll destroy all bricks)
		} else {
			loadSprites ();
		}
		//Debug.Log(hitCount);
	}

	void loadSprites(){
		int index = hitCount - 1;
		if(hitSprites[index])this.GetComponent<SpriteRenderer> ().sprite = hitSprites [index];
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
