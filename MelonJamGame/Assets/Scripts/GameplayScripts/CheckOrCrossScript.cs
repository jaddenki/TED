using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckOrCrossScript : MonoBehaviour
{

    [SerializeField] private AudioClip correctSound;
    [SerializeField] private AudioClip incorrectSound;
    private AudioSource audioSource;

    public GameObject number, number2, number3;
    public Sprite[] imageArray;
    private RawImage rawImage;
    private CharmTest int_script, white_charm;
    private ImageController int_script2, displayControl;
    private TimerScript timer_script, timer_running, timer_maxTime;
    public float newMaxTime = 5f;
    public int mistakes, successes = 0;
    public bool checking = false;
    public bool changeCharm = false;
    public bool hasTimeRunOut = true;
    public bool mistakeAnim, successAnim = false;


    void Start()
    {
        int_script = number.GetComponent<CharmTest>();
        int_script2 = number2.GetComponent<ImageController>();
        timer_running = number3.GetComponent<TimerScript>();
        displayControl = number2.GetComponent<ImageController>();
        timer_maxTime = number3.GetComponent<TimerScript>();


    }

    void Update()
    {
        if(mistakes >= 3)
        {
            StartCoroutine(WompWomp());
        }
        if(successes >= 20)
        {
            StartCoroutine(yay());
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
        newMaxTime = (5f - (successes * 0.175f));
        timer_maxTime.maxTime = newMaxTime;
        timer_script.timeLeft = newMaxTime;
        timer_running.isTimeRunning = true;
        displayControl.display = true;
        white_charm.colorNumber = 7;
        changeCharm = true;
        hasTimeRunOut = true;
        successAnim = false;
        mistakeAnim = false;
    }
    void CheckForCorrect()
    {
        rawImage = GetComponent<RawImage>();
        if (int_script.colorNumber == int_script2.randomIndex)
        {
            audioSource = GetComponent<AudioSource>();
            successAnim = true;
            rawImage.texture = imageArray[0].texture;
            successes++;
            //Success animation should go here i think
            Debug.Log("Successes: " + successes);
            audioSource.clip = correctSound;
            audioSource.Play();
        }
        else
        {
                    audioSource = GetComponent<AudioSource>();
            mistakeAnim = true;
            rawImage.texture = imageArray[1].texture;
            mistakes++;
            //Mistake animation should go here i think
            Debug.Log("Mistakes: " + mistakes);
            audioSource.clip = incorrectSound;
            audioSource.Play();
        }
    }

    IEnumerator yay()
    {

        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene("yay");
    }
    IEnumerator WompWomp()
    {
        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene("WompWomp");
    }
}
