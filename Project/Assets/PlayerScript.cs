using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public float speed;
	private Vector3 enemyPos;
	private GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;
	private GameObject origin;
	public GameObject hammer;
	bool created;

	// Use this for initialization
	void Start () {
		origin = GameObject.FindGameObjectWithTag ("PlayerOrigin");
		created = false;
	}
	
	// Update is called once per framw
	void FixedUpdate (){
		if (this.transform.position.x >= enemyPos.x) {
			this.rigidbody2D.velocity = new Vector2(0,0);
			GameEvents.OnMove(true);
			created = false;
		}
		if (this.transform.position.x < origin.transform.position.x) {
			this.rigidbody2D.velocity = new Vector2(0,0);
			this.transform.position = origin.transform.position;
			GameEvents.OnMove(false);

			if (!created){
				GameObject hammerClone = Instantiate(hammer) as GameObject;
				GameEventsScript.GameEventsInstance.OnResetHammer();
				created = true;
			}
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
