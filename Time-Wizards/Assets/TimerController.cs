using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{ 
    // TODO:
    // Countdown will not print properly due to reducing before it sets the timer default ??????

    [SerializeField] int totalTime = 300; // 5 Minutes
    [SerializeField] TimerController countdownTimer;
    Text TimerLabel;

    // timer needs to go down and up
    // timer needs a base time to go down from

    // Start is called before the first frame update
    void Start()
    {
        TimerLabel = FindObjectOfType<Text>();
        SetTimerLabelText();
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (totalTime > 0)
        {
            yield return new WaitForSeconds(1);
            totalTime--;
            SetTimerLabelText();
        }
    }

    private void SetTimerLabelText()
    {
        TimerLabel.text = GetTimerFormatted(totalTime);
    }

    string GetTimerFormatted(int totalTime)
    {
        string timerText = string.Empty;

        TimerStructure timeConverted = GetTimeConverted(totalTime);

        timerText = "Time: " 
            + timeConverted.Minutes.ToString().PadLeft(2, '0') 
            + ":" 
            + timeConverted.Seconds.ToString().PadLeft(2, '0');

        return timerText;
    }

    TimerStructure GetTimeConverted(int totalTime)
    {
        int minutes = totalTime / 60;
        int seconds = totalTime % 60;

        TimerStructure timerStructure = new TimerStructure(minutes, seconds);

        return timerStructure;
    }

    public void AddTime(int time)
    {
        totalTime += time;
    }

    public void RemoveTime(int time)
    {
        totalTime -= time;
    }
}
