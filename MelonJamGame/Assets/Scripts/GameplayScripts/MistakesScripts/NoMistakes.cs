using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoMistakes : MonoBehaviour
{
    Image image;
    public GameObject number;
    private CheckOrCrossScript mistakes_script;
    public int m = 0;
    // Start is called before the first frame update
    void Start()
    {
        mistakes_script = number.GetComponent<CheckOrCrossScript>();
    }

    // Update is called once per frame
    void Update()
    {
        image = GetComponent<Image>();
        if (mistakes_script.mistakes > 0)
        {
            image.color = Color.clear;
        }
        if (mistakes_script.mistakes == 1)
        {
            m = 1;
        }
        if (mistakes_script.mistakes == 2)
        {
            m = 2;
        }
        if (mistakes_script.mistakes == 3)
        {
            m = 3;
        }
    }
}
