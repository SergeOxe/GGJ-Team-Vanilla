﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed;
	private Vector3 enemyPos;
	private GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per framw
	void FixedUpdate (){
		if (this.transform.position.x >= enemyPos.x) {
			this.rigidbody2D.velocity = new Vector2(0,0);
			GameEvents.OnMove(true);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			//GameOver
			print("GameOver");
		}
	}

	public void moveTo(Vector3 pos){
		enemyPos = pos;
		this.rigidbody2D.velocity = new Vector3 (1, 0, 0) * speed;
	}
}
