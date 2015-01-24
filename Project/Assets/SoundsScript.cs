using UnityEngine;
using System.Collections;

public class SoundsScript : MonoBehaviour {
	
	public AudioSource ClickFX;
	public AudioClip audio;

	void Start(){
		ClickFX = GetComponent<AudioSource>();
	}

	void playSound(){
		ClickFX.Play();
	}
	void playAudioClip(){
		AudioSource.PlayClipAtPoint (audio, transform.position);
	}
}
