using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour
{
    public int choice;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            choice = 1;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            choice = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            choice = 3;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            choice = 4;
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            choice = 5;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            choice = 6;
        }
        Debug.Log(choice);
    }
}
