using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparkleWhenHit : MonoBehaviour {
	//public Transform sparkle;
	// Use this for initialization
	void Start () {
		//sparkle = GameObject.FindObjectOfType<Transform> ();
		this.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void getHit(){ //call this when get hit
		this.GetComponent<ParticleSystem> ().enableEmission = true;
		StartCoroutine (stopParticles());
	}

	IEnumerator stopParticles(){
		yield return new WaitForSeconds (.4f);
		this.GetComponent<ParticleSystem> ().enableEmission = false;
	}
}
