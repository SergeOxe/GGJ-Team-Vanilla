using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	private GameEventsScript gameEvents =  GameEventsScript.GameEventsInstance;
	private GameObject player;
	public float minX;
	public float maxX;
	public GameObject[] enemies;
	private GameObject nextEnemy;
    private Animator anim;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		nextEnemy = enemies [Random.Range (0, enemies.Length)];
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D collision) {
		print (collision.gameObject.tag);
		//player.GetComponent<PlayerScript> ().moveTo (this.transform.position);
		if (collision.gameObject.tag == "HammerHead") {
			gameEvents.OnHitMonster();
			anim.SetTrigger("explode");
			player.GetComponent<PlayerScript> ().moveTo (this.transform.position);
			gameEvents.OnIncreamentScore(10);
			Instantiate(nextEnemy,new Vector3(Random.Range (minX,maxX),this.transform.position.y,0),Quaternion.identity);
			Destroy(this.gameObject.collider2D);
			//Destroy(collision.gameObject);
			//Destroy(this.gameObject);
			
		}
		if (collision.gameObject.tag == "Stick") {
			GameEventsScript.GameEventsInstance.OnPlayDirtAnimation(GameObject.FindGameObjectWithTag("Hammer").transform.position);
		}
	}

    void CallOnAnimationEnd()
    {
        Destroy (this.gameObject);
    }
}
