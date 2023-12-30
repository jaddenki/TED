using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    UnityEngine.UI.Image timerBar;
    public float maxTime = 5f;
    public float timeLeft;
    public GameObject timesUpText, timeOut;
    private CheckOrCrossScript time_off;
    public bool isTimeRunning = true;


    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<UnityEngine.UI.Image>();
        time_off = timeOut.GetComponent<CheckOrCrossScript>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0 && timeLeft != 0.001f)
        {
            if (isTimeRunning == true)
            {
                timesUpText.SetActive(false);
                timeLeft -= Time.deltaTime;
                timerBar.fillAmount = timeLeft / maxTime;
            }
        }
        else if (timeLeft == 0.001f)
        {
            if(time_off.hasTimeRunOut != false)
            {
                timesUpText.SetActive(true);
            }
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}