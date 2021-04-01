using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plusscript : MonoBehaviour
{
    public static int mins;
    public static int secs;
    public Text minstext;
    public static int mincounter;
    void Start()
    {
        mins = 0;
        secs = 0;
        mincounter = 60;
    }
    void Update()
    {

    }
    public void AddMin()
    {
        mins = mins+1;
        string mins_res = string.Format("{0:0}:{1:00}", mins, secs);
        minstext.text = mins_res;
    }
    public void LessMin()
    {
        if (mins < 1)
        {
        }
        else
        {
            mins = mins - 1;
        }
        string mins_res = string.Format("{0:0}:{1:00}", mins, secs);
        minstext.text = mins_res;
    }
    public void AddSec()
    {
        if (secs == 59 && mins >= 0)
        {
            secs = 0;
            mins++;
        }
        else if (secs >= 0 && mins > -1)
        {
            secs++;
        }
        string mins_res = string.Format("{0:0}:{1:00}", mins, secs);
        minstext.text = mins_res;
    }
    public void LessSec()
    {
        if (secs == 0 && mins > 0)
        {
            secs = 59;
            mins--;
        }
        else if (secs > 0 &&  mins > -1)
        {
            secs--;
        }
        string mins_res = string.Format("{0:0}:{1:00}", mins, secs);
        minstext.text = mins_res;
    }
   
}
 