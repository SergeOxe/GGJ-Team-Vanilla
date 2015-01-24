using UnityEngine;
using System.Collections;

public class SoundsScript : MonoBehaviour {
	
	AudioSource ClickFX;

	void Start(){
		ClickFX = GetComponent<AudioSource>();
	}

	void playSound(){
		ClickFX.Play();
	}
}
