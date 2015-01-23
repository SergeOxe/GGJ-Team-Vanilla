using UnityEngine;
using System;

public class GameEventsScript {

	public Action<int> increamentScore;

    private static GameEventsScript s_GameEvents;
    private static int s_HighScore;
    private static int s_Score;

    private GameEventsScript()
    {
        s_Score = 0;
        s_HighScore = 0;
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
        s_Score += value;
        if (s_Score > s_HighScore)
            s_HighScore = s_Score;
        if (increamentScore != null)
            increamentScore(s_Score);
    }

    public int getScore()
    {
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
}
