using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WompButtonControl : MonoBehaviour
{
    public float transitionTime = 1f;
    public void toTheFinalScene()
    {
        StartCoroutine(NextScene());
    }

    IEnumerator NextScene()
    {

        // Waitfor the transition animation to complete
        yield return new WaitForSeconds(transitionTime);

        // Load the next scene
        SceneManager.LoadScene("TedDead");

    }
}
