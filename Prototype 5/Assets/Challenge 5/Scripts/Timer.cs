using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60;

    public bool timerIsRunning = false;

    public Text timer;

    private void Start()
    {
        // Starts timer
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                DisplayTime(timeLeft);
            }

            else
            {
                Debug.Log("Timed Out!");
                timeLeft = 0;
                timerIsRunning = false;
            }
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeLeft % 60);

        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
