using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour {

    float timeLeft = 60.0f;
    public UnityEngine.UI.Text Time;
    private bool isGameStarted = false;

    public UnityEngine.UI.Text goldDisplay;
    public int gold = 0;
    public int goldperclick = 1;

    private bool gameEnded = false;

    void Update()
    {
        goldDisplay.text = "Score: " + gold;

        if (timeLeft > 0 && gameEnded == false)
        {
            timeLeft -= UnityEngine.Time.deltaTime;
            Time.text = "" + Mathf.Round(timeLeft);

            if (timeLeft < 0)
            {
                timeLeft = 0;
                isGameStarted = false;
                gameEnded = true; // prevent from calling all the text updates after time is less than 0 and pin it at 0
            }
        }

        if (gameEnded == true)
        {
            SceneManager.LoadScene(0); // do something, popup a game ended canvas, load a level, whatever.
        }
    }

    public void Clicked()
    {
        if (isGameStarted)
        {
            gold += goldperclick;
        }
        else
        {
            isGameStarted = true; // isGameStarted is false on the first click
                                  // if you want to get gold on the first click uncomment out below
            gold += goldperclick;
        }
    }
}
