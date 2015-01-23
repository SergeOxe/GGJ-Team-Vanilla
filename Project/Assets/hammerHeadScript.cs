using UnityEngine;
using System.Collections;

public class hammerHeadScript : MonoBehaviour {

	private GameObject stick;
	GameEventsScript gameEvents = GameEventsScript.GameEventsInstance;
	public float offsetY;

	void Start(){
		stick = GameObject.FindGameObjectWithTag ("Stick");
	}

	void Update(){
		//float newY = stick.gameObject.collider2D.bounds.max.y;
		//this.transform.position = new Vector3 (stick.gameObject.transform.position.x,newY+offsetY, 1);

	}


	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Ground") {
			gameEvents.OnGameOver();
			//SApplication.LoadLevel("game_over_GUI");
		}
	}
}
