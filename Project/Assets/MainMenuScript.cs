using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

    private GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;

    public void OnPlayButtonClick()
    {
        GameEvents.OnGameRestart();
        Application.LoadLevel("Game_GUI");
    }
}
