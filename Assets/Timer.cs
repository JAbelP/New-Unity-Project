using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Timer : MonoBehaviour
{


    public static float currentTime;
    public Text currentTimeText;
    public static TimeSpan time;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;    
    }

    // Update is called once per frame
    void Update() 
    {
        currentTime = currentTime + Time.deltaTime;   
        time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.ToString(@"mm\:ss\:fff");

    }


}
