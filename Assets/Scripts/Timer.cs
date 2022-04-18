using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Timer
{
    static private TimeSpan timePlaying;
    static public bool isTimerOn = false;
    static private float timeElapsed = 0f;
    static public string timerStr = "00:00:00";

    public static void EndTimer()
    {
        isTimerOn = false;
    }

    public static IEnumerator UpdateTimer()
    {
        while (isTimerOn)
        {
            timeElapsed += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timeElapsed);
            timerStr = timePlaying.ToString(@"mm\:ss\:ff");
            yield return null;
        }
    }
}
