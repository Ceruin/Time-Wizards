using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{ 
    [SerializeField] float totalTime = 300f; // 5 Minutes

    Text countdownTimer;

    // timer needs to go down and up
    // timer needs a base time to go down from

    // Start is called before the first frame update
    void Start()
    {
        countdownTimer = GetComponent<Text>();
        StartCoroutine(Countdown());
        for (int i = 0; i < 1000000000; i++) {
            print("poop");
        }
    }

    IEnumerator Countdown()
    {        
        while (totalTime >= 0)
        {
            totalTime--;
            countdownTimer.text = "Time: " + totalTime;
            yield return new WaitForSeconds(1);
        }
    }

    int GetMinutes(int totalTime)
    {

        return 0;
    }
}
