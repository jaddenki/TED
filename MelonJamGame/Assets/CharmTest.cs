using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharmTest : MonoBehaviour
{

    Renderer ren;
    Color orange = new Color(1.0f, 0.64f, 0.0f);
    Color purple = new Color(0.5f, 0, 0.5f);

    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.red;
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = orange;
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.yellow;
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.green;
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.blue;
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = purple;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.clear;
        }
    }
}
