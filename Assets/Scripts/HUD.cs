using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    /// <summary>
    /// Used for providing the game timer 
    /// </summary>
    [SerializeField]
    Text scoreText;
    float elapsedSeconds = 0f;
    static int scoreTime = 0;
    bool timerRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            elapsedSeconds += Time.deltaTime;
            scoreTime = (int)elapsedSeconds;
        }
        scoreText.text = scoreTime.ToString();
    }

    public void StopGameTimer()
    {
        timerRunning = false;
    }
}
