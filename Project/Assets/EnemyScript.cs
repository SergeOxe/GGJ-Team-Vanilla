using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	private GameEventsScript gameEvents =  GameEventsScript.GameEventsInstance;
	private GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		player.GetComponent<PlayerScript> ().moveTo (this.transform.position);
		if (collision.gameObject.tag == "Hammer") {
			gameEvents.OnIncreamentScore(10);	

			Destroy (this.gameObject);
		}
		if (collision.gameObject.tag == "Stick") {
			Destroy (collision.gameObject.collider2D);
		}
	}
}
