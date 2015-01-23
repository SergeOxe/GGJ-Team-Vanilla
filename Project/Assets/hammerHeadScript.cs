using UnityEngine;
using System.Collections;

public class hammerHeadScript : MonoBehaviour {

	private GameObject stick;

	// Use this for initialization
	void Start () {
		stick = GameObject.FindGameObjectWithTag ("Stick");
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (this.transform.position.x, stick.collider2D.bounds.max.y, 1);;
	
	}
}
