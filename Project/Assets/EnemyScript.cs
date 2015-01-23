using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	private GameEventsScript gameEvents =  GameEventsScript.GameEventsInstance;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Hammer") {
			gameEvents.increamentScore(10);	
			Destroy (this.gameObject);
		}
		if (collision.gameObject.tag == "Stick") {
			Destroy (collision.gameObject.collider2D);
		}
	}
}
