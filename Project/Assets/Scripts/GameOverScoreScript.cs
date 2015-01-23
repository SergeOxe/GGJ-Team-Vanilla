using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameOverScoreScript : MonoBehaviour {

    public Text textObject;

    private static string gameOverString = "Score\n{0}\nHigh Score\n{1}";

    GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;

    private int score;
    private int highScore;

	// Use this for initialization
	void Start () {
        score = GameEvents.getScore();
        highScore = GameEvents.getHighScore();
        textObject.text = String.Format(gameOverString, score, highScore);
	}

    public void OnRestartButtonClick()
    {
        GameEvents.OnGameRestart();
        Application.LoadLevel("Game_GUI");
    }
}
