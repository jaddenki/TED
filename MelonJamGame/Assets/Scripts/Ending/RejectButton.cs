using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RejectButton : MonoBehaviour
{
    public void toReject()
    {
        SceneManager.LoadScene("Rejected");
    }

    public void toBag()
    // HE BAGS THE GIRL RAHHHHH
    {
        SceneManager.LoadScene("TEDwins");
    }
}
