using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update

    public Text timertext;
    private float starttimer;
    void Start()
    {
        starttimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - starttimer;
        float display = 80.0f - t;
        timertext.text = "Time remaining  " + display.ToString("f2");

    }
}
