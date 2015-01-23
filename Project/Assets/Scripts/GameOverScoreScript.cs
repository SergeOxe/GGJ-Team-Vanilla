using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameOverScoreScript : MonoBehaviour {

    public GameObject Controller;
    public Text textObject;

    private static string gameOverString = "Score\n{0)\nHigh Score\n{1}";

    GameEventsScript GameEvents = GameEventsScript.GameEvents;

    private int score;
    private int highScore;

	// Use this for initialization
	void Start () {
        score = GameEvents.getScore();
        highScore = GameEvents.getHighScore();
        textObject.text = String.Format(gameOverString, score, highScore);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
