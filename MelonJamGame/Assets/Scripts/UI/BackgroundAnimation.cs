using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAnimation : MonoBehaviour
{
    public Sprite[] backgroundFrames;
    public float frameInterval = 2f; // Time interval between frames

    private SpriteRenderer spriteRenderer;
    private int currentFrameIndex = 0;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("NextFrame", 0f, frameInterval);
    }

    void NextFrame()
    {
        // Change the sprite to the next frame
        spriteRenderer.sprite = backgroundFrames[currentFrameIndex];

        // Move to the next frame index
        currentFrameIndex = (currentFrameIndex + 1) % backgroundFrames.Length;
    }
}
