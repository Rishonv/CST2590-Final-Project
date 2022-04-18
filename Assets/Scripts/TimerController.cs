using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private Text timerText;

    void Start()
    {
        if (!Timer.isTimerOn)
        {
            Timer.isTimerOn = true;
            StartCoroutine(Timer.UpdateTimer());
        }
    }

    void Update()
    {
        timerText.text = Timer.timerStr;
    }

    void OnDestroy()
    {
        Timer.EndTimer();
    }
}
