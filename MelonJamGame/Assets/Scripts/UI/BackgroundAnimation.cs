using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimation : MonoBehaviour
{
    public Sprite[] Idle;
    public Sprite[] Correct;
    public Sprite[] Incorrect;
    public float frameInterval = 0.2f; // Time interval between frames

    private SpriteRenderer spriteRenderer;
    private int currentFrameIndex = 0;
    private int poo;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("NextFrame", 0f, frameInterval);
    }

    void NextFrame()
    {
  
        // condition for the correct animation
        if (Input.GetKey(KeyCode.C))
        {
            spriteRenderer.sprite = Correct[currentFrameIndex];
            Debug.Log("I press C");
            poo = 9;
        }
        // condition for the incorrect animation
        else if (Input.GetKey(KeyCode.M))
        {
            spriteRenderer.sprite = Incorrect[currentFrameIndex];
            Debug.Log("I pres M");
            poo = 9;
        }
        else
        {
            spriteRenderer.sprite = Idle[currentFrameIndex];
            poo = 9;
        }

        // Move to the next frame index
        currentFrameIndex = (currentFrameIndex + 1) % poo;
    }
}
