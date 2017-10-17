using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	public bool autoPlay = false;
	public float minX, maxX;
	private Ball ball;
	// Use this for initialization
	void Start () {
		ball=GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay)
			moveWithMouse ();
		else {
			AutoPlay ();
		}
	}

	void AutoPlay(){
		Vector3 ballPos = new Vector3(ball.transform.position.x,this.transform.position.y,this.transform.position.z);
		this.transform.position = ballPos;
	}

	void moveWithMouse(){
		//print (Input.mousePosition);
		float mousePosInBlock;
		mousePosInBlock=Input.mousePosition.x/Screen.width*16;//give [0,1] multiply by 16 because of 16 world unit wide
		//print(mousePosInBlock);
		//this.transform.position.x = mousePosInBlock;  Unity won't let we change x directly we must change at position by Vector3
		Vector3 paddlePos = new Vector3(0.5f,this.transform.position.y,this.transform.position.z); //start at left , will this var declare as new obj every frame???
		paddlePos.x = Mathf.Clamp(mousePosInBlock,minX,maxX); //set minimum pos to 0.5f and maximum to 15.5f (1f,15f for new paddle)
		this.transform.position = paddlePos;
	}
}
