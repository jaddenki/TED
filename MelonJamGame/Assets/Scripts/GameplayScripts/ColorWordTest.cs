using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    public int randomIndex;
    public Sprite[] imageArray;
    private RawImage Rawimage;

    private void Start()
    {
        DisplayRandomImage();
    }

    public void DisplayRandomImage()
    {
        RawImage rawImage = GetComponent<RawImage>();

        randomIndex = Random.Range(0, 5);

        rawImage.texture = imageArray[randomIndex].texture;
    }
}