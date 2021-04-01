using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    public static int secs;
    public Slider timerSlider;
    public Text minstext;
    void Start()
    {
        secs = 0;
        timerSlider.maxValue = 999;
    }
    void Update()
    {
        timerSlider.value = secs;
    }


    public void AddSecs()
    {
        secs++;
        string mins_res = secs.ToString();
        minstext.text = mins_res;
    }
    public void LessSecs()
    {
        if (secs < 1)
        {

        }
        else
        {
            secs--;

            string mins_res = secs.ToString();
            minstext.text = mins_res;
        }
    }

}
