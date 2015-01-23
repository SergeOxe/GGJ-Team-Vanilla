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
		this.transform.position = stick.collider2D.bounds.extents;
	
	}
}
