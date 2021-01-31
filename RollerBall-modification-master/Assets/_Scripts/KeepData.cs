using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//attached to data manager object in all scenes

public class KeepData : MonoBehaviour
{
    public static string PlayerName = "default name";
    public static bool OversizedBall ;
    public static int RoundsToPlay = 3;
    public static float PlayerSpeedMultiplier = 1.0f; // the default in the tutorial is 800 and a little fast
    public static int Currentscore = 0; //score of the last game played
    public static int HighScore = 0; // highest score so far

    // inputs on the introduction screen
    public InputField playerName;
    public Toggle ballSize;
    public Dropdown roundsToPlay;
    public Slider playerSpeedMultiplier;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); 
    }
    public void UpdateName() // updates on input change for input field
    {
        PlayerName = playerName.text;
    }
    public void BigBall (bool newValue)
    {
        OversizedBall = newValue;
    }
   public void SetRoundsToPlay()
    {
        switch (roundsToPlay.value)
        {
            case 1:
                RoundsToPlay = 1;
                break;
            case 2:
                RoundsToPlay = 2;
                break;
            case 3:
                RoundsToPlay = 3;
                break;
            case 4:
                RoundsToPlay = 4;
                break;
            default:
                RoundsToPlay = 1;
                break;
        }
    }
    public void SetPlayerSpeedMultiplier()
    {
        PlayerSpeedMultiplier = playerSpeedMultiplier.value; // value of the slider
    }
}
