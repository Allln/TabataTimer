using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    public void RestartGame()
    {
        SceneManager.LoadScene("0");
    }
    public void RestartGameT()
    {
        SceneManager.LoadScene("1");
        TimeControlerTabata.stopTimer = true;
    }
    public void Tabata()
    {
        SceneManager.LoadScene("1");
    }
    public void Counter()
    {
        SceneManager.LoadScene("2");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("0");
    }
}
