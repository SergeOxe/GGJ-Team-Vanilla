using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameOverScoreScript : MonoBehaviour {

    public Text textObject;

    private static string gameOverString = "Score\n{0}\nHigh Score\n{1}";

    GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;
    AudioSource ClickFX;

    private int score;
    private int highScore;

	// Use this for initialization
	void Start () {
        ClickFX = GetComponent<AudioSource>();
        score = GameEvents.getScore();
        highScore = GameEvents.getHighScore();
        textObject.text = String.Format(gameOverString, score, highScore);
	}

    public void OnRestartButtonClick()
    {
        ClickFX.Play();
        GameEvents.OnGameRestart();
        Application.LoadLevel("Game_GUI");
    }
}
