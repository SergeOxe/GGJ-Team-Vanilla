using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

    public Text ScoreText;

    GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;

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
            Application.LoadLevel("game_over_GUI");
    }

    void ScoreChangedListener(int value)
    {
        score = value;
        ScoreText.text = score.ToString();
    }

    void OnDestroy()
    {
        GameEvents.increamentScore -= ScoreChangedListener;
    }

}
