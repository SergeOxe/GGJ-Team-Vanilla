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
	public GameObject head;
	// Use this for initialization
	void Start () {
		collisionWithPlayer = false;
		keyPressedTime = 0;
		canPress = true;
		head = GameObject.FindGameObjectWithTag ("Hammer");
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
					this.rigidbody2D.isKinematic = false;
					this.rigidbody2D.AddForce ((new Vector2 (1, 0)) * forcePush);
			}
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
