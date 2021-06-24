using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class FinalLevelNext : MonoBehaviour
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
            HoldingScore.levelThree= SandTime.time.ToString(@"mm\:ss\:fff");
            Debug.Log("This is Level Three Time");
            Debug.Log(HoldingScore.levelThree);//String



            HoldingScore.currentTimer = SandTime.currentTimeTotal;
            Debug.Log("This is current Time");
            Debug.Log(TimeSpan.FromSeconds(HoldingScore.currentTimer).ToString(@"mm\:ss\:fff"));//float turn into a string


          

            SceneManager.LoadScene(3);
  
        }



    }
}
