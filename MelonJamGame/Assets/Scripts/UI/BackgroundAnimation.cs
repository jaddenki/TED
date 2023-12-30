using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundAnimation : MonoBehaviour
{
    public Sprite[] Idle;
    public Sprite[] Correct;
    public Sprite[] Incorrect;
    public float frameInterval = 0.2f; // Time interval between frames
    public GameObject anim;
    private CheckOrCrossScript anim_script;

    private SpriteRenderer spriteRenderer;
    private int currentFrameIndex = 0;
    private int poo;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("NextFrame", 0f, frameInterval);
        anim_script = anim.GetComponent<CheckOrCrossScript>();
    }

    void NextFrame()
    {

        // condition for the correct animation
        if (anim_script.successAnim == true)
        {
            spriteRenderer.sprite = Correct[currentFrameIndex];
            Debug.Log("FI: " + currentFrameIndex);
            Debug.Log("Success");
            poo = 9;
        }
        // condition for the incorrect animation
        else if (anim_script.mistakeAnim == true)
        {
            spriteRenderer.sprite = Incorrect[currentFrameIndex];
            Debug.Log("FI: " + currentFrameIndex);
            Debug.Log("Fail");
            poo = 9;
        }
        else
        {
            spriteRenderer.sprite = Idle[currentFrameIndex];
            poo = 3;
        }

        // Move to the next frame index
        currentFrameIndex = (currentFrameIndex + 1) % poo;
    }
}
