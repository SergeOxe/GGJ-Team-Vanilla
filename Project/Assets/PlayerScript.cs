using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f,0.0f );
		rigidbody2D.velocity = movement * speed;
	
	}
}
