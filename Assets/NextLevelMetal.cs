using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class NextLevelMetal : MonoBehaviour
{
    int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Target");
        count = objects.Length;
        if (count == 0){
                       //make the value HoldingScores.levelOne = Timer.time; 
            HoldingScore.levelTwo = MetalTime.time.ToString(@"mm\:ss\:fff");
            Debug.Log("This is Level Two Time");
            Debug.Log(HoldingScore.levelTwo);//String



            HoldingScore.currentTimer = MetalTime.currentTimeTotal;
            Debug.Log("This is current Time");
            Debug.Log(TimeSpan.FromSeconds(HoldingScore.currentTimer).ToString(@"mm\:ss\:fff"));//float turn into a string


          

            SceneManager.LoadScene(2);
        }
    }
}
