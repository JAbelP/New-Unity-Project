using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTargets : MonoBehaviour
{


    public Text TargetsLeft;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Target");
        count = objects.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        TargetsLeft.text = count.ToString();
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Target");
        count = objects.Length;
    }
}
