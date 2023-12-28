using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OButtonControls : MonoBehaviour
{
    Renderer ren;

    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.color = Color.clear;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
    }
}
