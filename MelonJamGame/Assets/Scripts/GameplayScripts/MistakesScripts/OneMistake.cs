using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneMistake : MonoBehaviour
{
    Image image;
    public GameObject numberone;
    private NoMistakes onemistake_script;
    public int n = 0;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = Color.clear;
        onemistake_script = numberone.GetComponent<NoMistakes>();
    }

    // Update is called once per frame
    void Update()
    {
        if(onemistake_script.m==1)
        {
            image.color = Color.white;
        }
        if(onemistake_script.m==2)
        {
            image.color = Color.white;
            n = 2;
        }
        if (onemistake_script.m == 3)
        {
            image.color = Color.white;
            n = 3;
        }
    }
}
