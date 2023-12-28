using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharmTest : MonoBehaviour
{

    Renderer ren;
    Color red = new Color(0.6f, 0.14f, 0.14f);
    Color orange = new Color(0.784f, 0.29f, 0.122f);
    Color yellow = new Color(0.886f, 0.82f, 0.08f);
    Color green = new Color(0.216f, 0.514f, 0.153f);
    Color blue = new Color(0.376f, 0.094f, 0.584f);
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
            ren.material.color = red;
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
            ren.material.color = yellow;
            colorNumber = 2;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = green;
            colorNumber = 3;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = blue;
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
