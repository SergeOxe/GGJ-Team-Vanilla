using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	private GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;

	public float speed;
	bool isMoving = false;
	private GameObject origin;

	void Start() {
		GameEvents.toTranslate += setIsMoving;
		origin = GameObject.FindGameObjectWithTag ("PlayerOrigin");
	}
	
	// Update is called once per frame
	void Update () {
		if (isMoving || Input.GetKey(KeyCode.LeftArrow)) {
            Debug.Log("Got here");
			this.transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
	}

	void setIsMoving(bool move)
	{
		isMoving = move;
	}

	void OnDestroy() {
		GameEvents.toTranslate -= setIsMoving;
	}
}
