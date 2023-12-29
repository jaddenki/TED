using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoMistakes : MonoBehaviour
{
    Image image;
    public GameObject numbertwo;
    private OneMistake twomistakes_script;
    public int o = 0;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = Color.clear;
        twomistakes_script = numbertwo.GetComponent<OneMistake>();
    }

    // Update is called once per frame
    void Update()
    {
        if (twomistakes_script.n == 2)
        {
            image.color = Color.white;
        }
        if (twomistakes_script.n == 3)
        {
            image.color = Color.clear;
            o = 3;
        }
    }
}
