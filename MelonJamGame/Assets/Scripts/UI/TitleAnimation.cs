using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAnimation : MonoBehaviour
{
    public Sprite[] Idle;

    public float frameInterval = 0.2f; // Time interval between frames

    private SpriteRenderer spriteRenderer;
    private int currentFrameIndex = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("NextFrame", 0f, frameInterval);
    }

    void NextFrame()
    {


            spriteRenderer.sprite = Idle[currentFrameIndex];

        // Move to the next frame index
        currentFrameIndex = (currentFrameIndex + 1) % Idle.Length;
    }
}
