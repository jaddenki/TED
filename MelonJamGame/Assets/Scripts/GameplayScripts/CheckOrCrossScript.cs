using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOrCrossScript : MonoBehaviour
{
    public GameObject number, number2;
    public Sprite[] imageArray;
    private RawImage rawImage;
    private CharmTest int_script;
    private ImageController int_script2;
    public int mistakes = 0;
    public int i = 0;

    void Start()
    {
        int_script = number.GetComponent<CharmTest>();
        int_script2 = number2.GetComponent<ImageController>();
    }
    
    void Update()
    {

    void gameplay()
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Invoke("checkForCorrect", 0.2f);
                Debug.Log("worked");
                Invoke("delay", 0.8f);
            }
        }

    }
    public void checkForCorrect()
    {
        if (int_script.colorNumber == int_script2.randomIndex)
        {
            RawImage rawImage = GetComponent<RawImage>();
            rawImage.texture = imageArray[0].texture;
        }
        else
        {
            RawImage rawImage = GetComponent<RawImage>();
            rawImage.texture = imageArray[1].texture;
            mistakes++;
            Debug.Log(mistakes);
        }
    }
    public void delay()
    {
        RawImage rawImage = GetComponent<RawImage>();
        rawImage.texture = imageArray[2].texture;
        Debug.Log("Worked2");
    }
}
