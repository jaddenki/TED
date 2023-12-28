using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharmTest : MonoBehaviour
{

    Renderer ren;
    Color orange = new Color(1.0f, 0.64f, 0.0f);
    Color purple = new Color(0.5f, 0, 0.5f);
    public int colorNumber = 7;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.red;
            colorNumber = 0;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = orange;
            colorNumber = 1;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.yellow;
            colorNumber = 2;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.green;
            colorNumber = 3;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.blue;
            colorNumber = 4;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = purple;
            colorNumber = 5;
        }
    }
}
