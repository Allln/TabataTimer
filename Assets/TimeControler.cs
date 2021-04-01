using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeControler : MonoBehaviour
{
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;
    public static bool stopTimer;
    public float startesc = 0;
    public AudioSource myFx;
    public AudioClip sound;

    void Start()
    {
        stopTimer = true;
        gameTime = start.secs;
    }

    // Update is called once per frame
    void Update()
    {
        if (stopTimer == false)
        {
            if(startesc == 0)
            {
                soundplay();
                startesc = Time.time;
            }
            gameTime = start.secs;
            timerSlider.maxValue = gameTime;
            timerSlider.value = gameTime;
            float time = gameTime - Time.time+startesc;
            Debug.Log(gameTime);
            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time - minutes * 60f);
            string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);
            
            if (time <= 0)
            {
                soundplay();
                stopTimer = true;
            }
            if (stopTimer == false)
            {
                timerText.text = textTime;
                timerSlider.value = time;
            }
        }
    }
    public void soundplay()
    {
        myFx.PlayOneShot(sound);
    }

}
