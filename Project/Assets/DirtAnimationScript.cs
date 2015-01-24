using UnityEngine;
using System.Collections;

public class DirtAnimationScript : MonoBehaviour {

    Animator anim;
    GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;

	void Start () {
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
        this.transform.position = position;
        anim.SetBool("Play", true);
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
