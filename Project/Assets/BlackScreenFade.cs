using UnityEngine;
using System.Collections;

public class BlackScreenFade : MonoBehaviour {

    GameEventsScript GameEvents = GameEventsScript.GameEventsInstance;
    SpriteRenderer blackScreen;
    bool gameOver = false;
    float gameOverTime;
    public float fadeSpeed = 0.5f;

    void Start()
    {
        GameEvents.gameOver += GameOverListener;
        blackScreen = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (gameOver)
        {
            blackScreen.color = Color.Lerp(blackScreen.color, Color.black, fadeSpeed * Time.deltaTime);
            if (Time.time - gameOverTime >= 2f)
                Application.LoadLevel("Game_GUI");
        }
    }

    void GameOverListener()
    {
        gameOver = true;
        gameOverTime = Time.time;
    }

    void OnDestroy()
    {
        GameEvents.gameOver -= GameOverListener;
    }
}
