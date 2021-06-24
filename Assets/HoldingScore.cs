using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HoldingScore : MonoBehaviour
{
    public static string levelOne;
    public static string levelTwo;
    public static string levelThree;
    public static float currentTimer;
    
    public Text levelONE;
    public Text levelTWO;
    public Text levelTHREE;
    public Text lastTimer;

    void Update()
    {
        levelONE.text = HoldingScore.levelOne;
        levelTWO.text = HoldingScore.levelTwo;
        levelTHREE.text = HoldingScore.levelThree;
        lastTimer.text = TimeSpan.FromSeconds(currentTimer).ToString(@"mm\:ss\:fff");
    }
}

