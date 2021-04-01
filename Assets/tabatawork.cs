using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tabatawork : MonoBehaviour
{
    public static int secs;
    public static int secsr;
    public static int round;
    public Text minstext;
    public Text finaltime;
    public static bool stopTimer;
    public float gameTime;
    public Text timerText;
    public float startesc = 0;
    void Start()
    {
        round = 1;
        secs = 0;
        secsr = 0;
        stopTimer = true;
        gameTime = start.secs;
    }
    void Update()
    {
        if (stopTimer == false)
        {
            if (startesc == 0)
            {
                startesc = Time.time;
            }
            gameTime = ((start.secstw + start.secstr)*start.roundsf)/2;
            float time = gameTime - Time.time + startesc;
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time - minutes * 60f);
            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            timerText.text = textTime;
        }
    }

    public void AddRound()
    {
        round++;
        string mins_res = round.ToString();
        minstext.text = mins_res;
    }
    public void LessRound()
    {
        if (round < 2)
        {

        }
        else {
            round--;
        string mins_res = round.ToString();
            minstext.text = mins_res;
        }
    }
    public void AddSec()
    {
        if (secs < 0)
        {
            secs = 0;
        }
        else
        {
            secs += 5;
            string mins_res = secs.ToString() + " s";
            minstext.text = mins_res;
        }
    }
    public void LessSec()
    {
        if (secs < 0)
        {
            secs = 0;
        }
        else
        {
            secs -= 5;
            string mins_res = secs.ToString() + " s";
            minstext.text = mins_res;
        }
    }
    public void AddSecr()
    {
        if (secsr < 0)
        {
            secsr = 0;
        }
        else
        {
            secsr += 5;
            string mins_res = secsr.ToString() + " s";
            minstext.text = mins_res;
        }
    }
    public void LessSecr()
    {
        if (secsr < 0)
        {
            secsr = 0;
        }
        else
        {
            secsr -= 5;
            string mins_res = secsr.ToString() + " s";
            minstext.text = mins_res;
        }
    }
    public void FinalTime()
    {
        int full = round * (secs + secsr);

        int minste = full / 60;
        int secste = full % 60;
        string mins_res = string.Format("{0:0}:{1:00}", minste, secste);
        finaltime.text = mins_res;
    }

}
