using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreeMistakes : MonoBehaviour
{
    Image image;
    public GameObject numberthree;
    private TwoMistakes threemistakes_script;
    public int o = 0;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.color = Color.clear;
        threemistakes_script = numberthree.GetComponent<TwoMistakes>();
    }

    // Update is called once per frame
    void Update()
    {
        if (threemistakes_script.o == 3)
        {
            image.color = Color.clear;
        }
    }
}
