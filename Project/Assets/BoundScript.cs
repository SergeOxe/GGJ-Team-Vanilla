using UnityEngine;
using System.Collections;

public class BoundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		print ("here "+col.gameObject.name);
		col.transform.position = new Vector3 (39.35f,col.transform.position.y, col.transform.position.z);
	}

	void OnTriggerEnter2D(Collider2D col){
		print ("here "+col.gameObject.name);
		col.transform.position = new Vector3 (39.35f,col.transform.position.y, col.transform.position.z);
	}
}
