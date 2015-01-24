using UnityEngine;
using System.Collections;

public class DirtAnimationScript : MonoBehaviour {

    Animator anim;
    GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;
	public Vector3 offset;
	private GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        GameEvents.dirtAnimation += OnPlayDirtAnimation;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Pressed D");
            GameEvents.OnPlayDirtAnimation(this.transform.position);

        }
    }
	
    void OnPlayDirtAnimation(Vector3 position) {
		Debug.Log ("DIrt");
        this.transform.position = position + offset;
        anim.SetBool("Play", true);
		player.GetComponent<PlayerScript> ().moveTo (new Vector3(20,0,1));
    }

    void StopAnimation()
    {
        anim.SetBool("Play", false);
    }

    void OnDestroy()
    {
        GameEvents.dirtAnimation -= OnPlayDirtAnimation;
    }
}
