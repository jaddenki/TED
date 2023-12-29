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
    public GameObject timesUpText;
    public bool isTimeRunning = true;


    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<UnityEngine.UI.Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            if (isTimeRunning == true)
            {
                timeLeft -= Time.deltaTime;
                timerBar.fillAmount = timeLeft / maxTime;
            }
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}