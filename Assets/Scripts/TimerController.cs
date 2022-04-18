using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class TimerController : MonoBehaviour
{
    public static TimerController instance;
    [SerializeField] private Text stopWatch;
    private TimeSpan timePlaying;
    private bool isTimerOn;
    private float timeElapsed;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        stopWatch.text = "Time: 00:00:00";
        isTimerOn = false;
    }

    public void BeginTimer()
    {
        isTimerOn = true;
        timeElapsed = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        isTimerOn = false;
    }

    private IEnumerator UpdateTimer()
    {
        while (isTimerOn)
        {
            timeElapsed += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(timeElapsed);
            string timePlayingStr = "Time: " + timePlaying.ToString("mm ':' ss ':' ff");
            stopWatch.text = timePlayingStr;
            yield return null;
        }
    }
}
