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
            GameEvents.OnIncreamentScore();
    }

    void ScoreChangedListener()
    {
        score++;
        ScoreText.text = score.ToString();
    }


}
