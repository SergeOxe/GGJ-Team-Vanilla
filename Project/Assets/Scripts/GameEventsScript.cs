using UnityEngine;
using System;

public class GameEventsScript : MonoBehaviour{

	public Action<int> increamentScore;

    private static GameEventsScript s_GameEvents;
    private static int s_HighScore;
    private static int s_Score;

    private GameEventsScript()
    {
        s_Score = 0;
        s_HighScore = 0;
    }

    public static GameEventsScript GameEvents
    {
        get
        {
            if (s_GameEvents == null)
                s_GameEvents = new GameEventsScript();
            return s_GameEvents;
        }
    }

    public void OnIncreamentScore(int value)
    {
        if (increamentScore != null)
            increamentScore(value);
    }

    public int getScore()
    {
        return s_Score;
    }

    public int getHighScore()
    {
        return s_HighScore;
    }

    public void OnChangeLevel(string nextLevel)
    {
        
    }
}
