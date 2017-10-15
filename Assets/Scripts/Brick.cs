using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public int maxHits;
	private int hitCount;

	//-----------------
	void OnCollisionEnter2D(Collision2D collision){ //when something hit it
		//Debug.Log(this.ToString+" get hit!!!");
		hitCount++;
		//Debug.Log(hitCount);
	}
	//----------------

	// Use this for initialization
	void Start () {
		hitCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
