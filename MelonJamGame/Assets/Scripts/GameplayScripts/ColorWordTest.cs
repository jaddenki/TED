using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public int randomIndex;
    public Sprite[] imageArray;
    private RawImage Rawimage;
    public bool display = true;

    private void Update()
    {
        if(display == true)
        {
            DisplayRandomImage();
        }
    }

    public void DisplayRandomImage()
    {
        RawImage rawImage = GetComponent<RawImage>();

        randomIndex = Random.Range(0, 6);

        rawImage.texture = imageArray[randomIndex].texture;
        display = false;
    }
}
