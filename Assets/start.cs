using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public static float secs = 0;
    public static float secstw = 0;
    public static float secstr = 0;
    public static float reps;
    public static int roundsf = 1;

    public void StartMe()
    {
        if ((plusscript.mins * 60 + plusscript.secs > 0) || (tabatawork.secs > 0 && (tabatawork.secsr > 0)))
        {
            TimeControler.stopTimer = false;
            TimeControlerTabata.stopTimer = false;
            tabatawork.stopTimer = false;
            secs = plusscript.mins * 60 + plusscript.secs;
            secstw = tabatawork.secs;
            secstr = tabatawork.secsr;
            reps = 0;
            try
            {
                roundsf = tabatawork.round*2;
            }
            catch
            {
                roundsf = 1;
            }
        }
        else
        {

        }

    } 
}
