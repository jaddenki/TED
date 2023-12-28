using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BButtonControls : MonoBehaviour
{
    Renderer ren;

    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.color = Color.clear;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.white;
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
    }
}
