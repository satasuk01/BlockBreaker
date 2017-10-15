using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	//public Paddle paddle;
	private Paddle paddle;
	private Vector3 paddleToBallVector;
	bool hasStarted=false;//To make sure that if we lauched the ball the ball won't be attached at the paddle anymore.
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();//when we make new scene we don't have to fix script target everytime make it find the target autometically
		//so make the paddle private
		//but in new version we don't have to do this just drag prefab into prefab
		paddleToBallVector = this.transform.position - paddle.transform.position; //distance between ball and paddle(Y axis)
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted) {
			//Lock the ball relative to the paddle.
			this.transform.position = paddle.transform.position + paddleToBallVector; //because the ball is on paddle(not in the paddle)
			//we have to set script execution order paddle first and then ball (make the ball attached to paddle or it will be detach or glitch when we move the paddle fast)

			//wait for a mouse press to launch.
			if (Input.GetMouseButtonDown (0)) {//0 for left 1 for right 2 for middle
				Debug.Log ("Left clicked");
				hasStarted = true;
				//this.rigidbody2D.velocity = new Vector2 (2f, 10f); can't use on newer version of unity
				this.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (2f, 14f); //shoot velocity
			}
		}
	}
}
