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

    void Start()
    {
        int_script = number.GetComponent<CharmTest>();
        int_script2 = number2.GetComponent<ImageController>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            checkForCorrect();
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
        }
    }
}
