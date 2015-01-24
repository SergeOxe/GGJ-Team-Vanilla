using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public float keyPressedTime;
	private bool playerPressed;
	public float maxTime;
	public float growSpeed;
	public float forcePush;
	public Collider2D circleCollider;
	private bool canPress;
	Vector2 size;
	private bool collisionWithPlayer;
	private GameObject head;
	private GameObject hand;
	private GameObject player;
	// Use this for initialization
	void Start () {
		collisionWithPlayer = false;
		keyPressedTime = 0;
		canPress = true;
		head = GameObject.FindGameObjectWithTag ("Hammer");
		hand = GameObject.FindGameObjectWithTag ("Hand");
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (canPress) {
			if (canPress && Input.GetMouseButton (0)) {
					playerPressed = true;
					keyPressedTime += Time.deltaTime;
					changeLadderSize ();
			}

			if (Input.GetMouseButtonUp (0) && playerPressed) {
					canPress = false;
					print (keyPressedTime);
					calcLength (keyPressedTime);
					keyPressedTime = 0;
					hand.rigidbody2D.isKinematic = false;
					hand.rigidbody2D.AddForce ((new Vector2 (1, 0)) * forcePush*3);
					this.rigidbody2D.isKinematic = false;
					this.rigidbody2D.AddForce ((new Vector2 (1, 0)) * forcePush);
			}
		}


		if (this.gameObject.GetComponent<HingeJoint2D>().jointAngle >= 90) {
			player.GetComponent<PlayerScript> ().moveTo (new Vector3(1.5f,1f,0f));
			print(GameObject.FindGameObjectWithTag("Hammer").gameObject.transform.position);
			Destroy(GameObject.FindGameObjectWithTag("ham"));
		}

	}

	void changeLadderSize ()
	{
		float yScale = this.transform.localScale.y +  growSpeed;
		this.transform.localScale = new Vector3 (this.transform.localScale.x, yScale, 0);
		head.transform.localScale = new Vector3 (head.transform.localScale.x, (1/yScale), 0);
		//this.transform.position = new Vector3 (this.transform.position.x,this.transform.position.y + (growSpeed-1)/2,1);
	}

	void calcLength (float time){
		if (time > maxTime) {
		}
	}

	void OnCollisionEnter2D(Collision2D col) {
	}

}
