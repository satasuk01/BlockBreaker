using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public AudioClip hitSound;
	public Sprite[] hitSprites;
	private bool isBreakable; //= (this.tag == "Breakable");
	private int maxHits;
	private int hitCount;

	public static int breakableBlocksCount = 0;
	//public LevelManager levelmanager;//not use find method cause new version don't need it
	private LevelManager levelmanager;
	//-----------------
	void OnCollisionEnter2D(Collision2D collision){ //when something hit it
		AudioSource.PlayClipAtPoint(hitSound, transform.position);
		if (isBreakable) handleHits();
		//Debug.Log (breakableBlocksCount);
	}

	void handleHits(){
		//Debug.Log(this.ToString+" get hit!!!");
		hitCount++;
		maxHits = hitSprites.Length + 1;
		if (hitCount >= maxHits) {
			breakableBlocksCount--;
			levelmanager.BrickDestroyed ();
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
		isBreakable = (this.tag == "Breakable");
		//keep track of breakable bricks
		if (isBreakable) {
			breakableBlocksCount++;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//TODO remove this method oncec we can actually win!
	void SimulateWin(){
		levelmanager.loadNextLevel ();
	}
}
