using UnityEngine;
using System.Collections;

public class DirtAnimationScript : MonoBehaviour {

    Animator anim;
    GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;

	void Start () {
        anim = GetComponent<Animator>();
        GameEvents.dritAnimation += OnPlayDirtAnimation;
	}
	
    void OnPlayDirtAnimation(Vector3 position) {
        this.transform.position = position;
        anim.SetBool("Play", true);
    }
	
}
