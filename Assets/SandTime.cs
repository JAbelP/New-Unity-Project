using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SandTime : MonoBehaviour
{
    //First Variable is used for main RED timer
    //2nd var is used for smaller 'total Time'
    
    public static float currentTime;
    public static float currentTimeTotal;

    public Text currentTimeText;
    public Text currentTimeTotalText;
    
    public static TimeSpan time;
    public static TimeSpan time2;


    // Start is called before the first frame update
    void Start()
    {
        currentTimeTotal = HoldingScore.currentTimer;
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");

        currentTimeTotal = currentTimeTotal + Time.deltaTime;
        time2 = TimeSpan.FromSeconds(currentTimeTotal);
        currentTimeTotalText.text = time2.ToString(@"mm\:ss\:fff");

        
    }
}
