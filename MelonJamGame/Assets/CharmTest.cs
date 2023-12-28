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
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = orange;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            ren = GetComponent<Renderer>();
            ren.material.color = purple;
        }
    }
}
