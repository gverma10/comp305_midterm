﻿using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    
    public void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Cloud")) {
			//this._cloudSound.Play ();
			//this.gameController.LivesValue -= 1;
		}
  	}
}
