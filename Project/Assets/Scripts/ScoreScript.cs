using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    public Text ScoreText;

    GameEventsScript GameEvents = GameEventsScript.GameEvents;

    private int score;

    void Start() 
    {
        score = 0;
        GameEvents.increamentScore += ScoreChangedListener;
        ScoreText.text = score.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            GameEvents.OnIncreamentScore(1);
        if(Input.GetKeyDown(KeyCode.L))
            GameEvents.OnChangeLevel("Game_Over");
    }

    void ScoreChangedListener(int value)
    {
        score += value;
        ScoreText.text = score.ToString();
    }

    void OnDestroy()
    {
        GameEvents.increamentScore -= ScoreChangedListener;
    }

}
