using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Introduction");
    }
    public void ExitGame()
    {
        // for real:
        // Application.Quit();
        // for development: 
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
