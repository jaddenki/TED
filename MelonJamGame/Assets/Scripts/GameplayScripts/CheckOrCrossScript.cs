using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckOrCrossScript : MonoBehaviour
{
    public GameObject number, number2, number3;
    public Sprite[] imageArray;
    private RawImage rawImage;
    private CharmTest int_script, white_charm;
    private ImageController int_script2, displayControl;
    private TimerScript timer_script, timer_running;
    public int mistakes, successes = 0;
    public bool checking = false;
    public bool changeCharm = false;
    public bool hasTimeRunOut = true;

    void Start()
    {
        int_script = number.GetComponent<CharmTest>();
        int_script2 = number2.GetComponent<ImageController>();
        timer_running = number3.GetComponent<TimerScript>();
        displayControl = number2.GetComponent<ImageController>();
    }

    void Update()
    {
        if(mistakes >= 3)
        {
            SceneManager.LoadScene("WompWomp");
        }
        if(successes >= 20)
        {
            SceneManager.LoadScene("yay");
        }
        timer_script = number3.GetComponent<TimerScript>();
        white_charm = number.GetComponent<CharmTest>();
        if(timer_script.timeLeft <= 0)
        {
            CheckForCorrect();
            StartCoroutine(Reaction());
        }
        if (Input.GetKeyDown(KeyCode.Space) && checking == false && white_charm.colorNumber != 7)
        {
            Debug.Log("Space key pressed");
            hasTimeRunOut = false;
            CheckForCorrect();
            StartCoroutine(Reaction());
        }
    }

    IEnumerator Reaction()
    {
        timer_running.isTimeRunning = false;
        timer_script.timeLeft = 0.001f;
        checking = true;
        Debug.Log("Delay started");
        Debug.Log(timer_script.timeLeft);
        yield return new WaitForSeconds(2.0f);
        Debug.Log("Delay finished");
        checking = false;
        rawImage = GetComponent<RawImage>();
        rawImage.texture = imageArray[2].texture;
        timer_script.timeLeft = 5f;
        timer_running.isTimeRunning = true;
        displayControl.display = true;
        white_charm.colorNumber = 7;
        changeCharm = true;
        hasTimeRunOut = true;
    }

    void CheckForCorrect()
    {
        rawImage = GetComponent<RawImage>();
        if (int_script.colorNumber == int_script2.randomIndex)
        {
            rawImage.texture = imageArray[0].texture;
            successes++;
            Debug.Log("Successes: " + successes);
        }
        else
        {
            rawImage.texture = imageArray[1].texture;
            mistakes++;
            Debug.Log("Mistakes: " + mistakes);
        }
    }
}
