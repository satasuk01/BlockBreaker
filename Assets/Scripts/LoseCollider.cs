using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//use to catch when the obj hit LoseCollider or trigger it(passing)
public class LoseCollider : MonoBehaviour {
	public LevelManager levelManager; //like we import LevelManger class

	void OnTriggerEnter2D(Collider2D trigger){ //pass(is Trigger ticked)
		Debug.Log("Trigger");
		levelManager.loadLevel("Lose");
	}
	void OnCollisionEnter2D(Collision2D collision){ //when something hit it
		Debug.Log("Collision");
	}





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
