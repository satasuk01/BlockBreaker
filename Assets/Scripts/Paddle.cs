using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//print (Input.mousePosition);
		float mousePosInBlock;
		mousePosInBlock=Input.mousePosition.x/Screen.width*16;//give [0,1] multiply by 16 because of 16 world unit wide
		//print(mousePosInBlock);
		//this.transform.position.x = mousePosInBlock;  Unity won't let we change x directly we must change at position by Vector3
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,this.transform.position.z); //start at left , will this var declare as new obj every frame???
		paddlePos.x = Mathf.Clamp(mousePosInBlock,0.5f,15.5f); //set minimum pos to 0.5 and maximum to 15.5
		this.transform.position = paddlePos;
	}
}
