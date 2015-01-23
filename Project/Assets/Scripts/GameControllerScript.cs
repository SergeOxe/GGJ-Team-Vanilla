using UnityEngine;
using System.Collections;

public class GameControllerScript : MonoBehaviour {
	public float keyPressedTime;
	private bool playerPressed;
	public float maxTime;
	public float growSpeed;

	// Use this for initialization
	void Start () {
		keyPressedTime = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			playerPressed = true;
			keyPressedTime += Time.deltaTime;
			changeLadderSize();
		}

		if(Input.GetMouseButtonUp(0) && playerPressed){
			print(keyPressedTime);
			calcLength(keyPressedTime);
			keyPressedTime = 0;
			playerPressed= false;
		}
	}

	void changeLadderSize ()
	{
		float yScale = this.transform.localScale.y +  growSpeed;
		this.transform.localScale = new Vector3 (1, yScale, 0);;
	}

	void calcLength (float time){
		if (time > maxTime) {
		}
	}
}
