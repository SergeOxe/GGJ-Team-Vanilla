using UnityEngine;
using System;

public class GameEventsScript {

	public Action increamentScore;

    private static GameEventsScript s_GameEvents;

    private GameEventsScript()
    {
        
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

    public void OnIncreamentScore()
    {
        if (increamentScore != null)
            increamentScore();
    }
}
