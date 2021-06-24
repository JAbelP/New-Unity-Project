using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class NextLevel : MonoBehaviour
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
            HoldingScore.levelOne = Timer.time.ToString(@"mm\:ss\:fff");
            HoldingScore.currentTimer = Timer.currentTime;
            Debug.Log("This is current Time");
            Debug.Log(TimeSpan.FromSeconds(HoldingScore.currentTimer).ToString(@"mm\:ss\:fff"));//float turn into a string


            Debug.Log("This is level one Time");
            Debug.Log(HoldingScore.levelOne);//String


            SceneManager.LoadScene(1);
        }
    }
}
