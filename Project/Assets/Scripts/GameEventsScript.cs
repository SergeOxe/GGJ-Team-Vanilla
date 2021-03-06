﻿using UnityEngine;
using System;

public class GameEventsScript {

	public Action<int> increamentScore;
	public Action<bool> toTranslate;
    public Action<Vector3> dirtAnimation;
    public Action gameOver;

    private static GameEventsScript s_GameEvents;
    private static int s_HighScore;
    private static int s_Score;
	private static bool playDirtAnimation = true;

    private GameEventsScript()
    {
        s_Score = 0;
        s_HighScore = PlayerPrefs.GetInt("high_score", 0);
    }

    public static GameEventsScript GameEventsInstance
    {
        get
        {
            if(s_GameEvents == null)
                s_GameEvents = new GameEventsScript();
            return s_GameEvents;
        }
    }

    public void OnIncreamentScore(int value)
    {
        Debug.Log("Updating score (by " + value + ")");
        s_Score += value;
        if (s_Score > s_HighScore)
        {
            s_HighScore = s_Score;
            PlayerPrefs.SetInt("high_score", s_HighScore);
        }
        if (increamentScore != null)
            increamentScore(s_Score);
    }

    public int getScore()
    {
        Debug.Log("Getting score (" + s_Score + ")");
        return s_Score;
    }

    public int getHighScore()
    {
        return s_HighScore;
    }

    public void OnGameRestart()
    {
        s_Score = 0;
    }
	public void OnGameOver()
	{
        if (gameOver != null)
            gameOver();
	}

	public void OnMove(bool isMove)
	{
		if (toTranslate != null)
			toTranslate (isMove);
	}

    public void OnPlayDirtAnimation(Vector3 pos)
    {
		if (playDirtAnimation && dirtAnimation != null) {
			dirtAnimation (pos);
		}
    }

	public void OnResetHammer() {
		playDirtAnimation = true;
	}

	public void OnHitMonster() {
		playDirtAnimation = false;
	}

}
