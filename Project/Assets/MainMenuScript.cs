using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    AudioSource ClickFX;

    private GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;

    void Start()
    {
        ClickFX = GetComponentInChildren<AudioSource>();
    }

    public void OnPlayButtonClick()
    {
        Debug.Log("Clicked");
        ClickFX.volume = 100;
        ClickFX.Play();
        GameEvents.OnGameRestart();
        Application.LoadLevel("scene_serge");
    }
}
