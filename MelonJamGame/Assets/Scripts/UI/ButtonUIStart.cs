using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUIStart : MonoBehaviour
{

    public void toTheMainScene()
    {
        SceneManager.LoadScene("Main");
    }

}
