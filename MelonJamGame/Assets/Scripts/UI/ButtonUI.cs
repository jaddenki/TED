using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    public void NewGameButton()
    {
        SceneManager.LoadScene("Intro");
    }
    
}
