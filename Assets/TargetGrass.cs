using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGrass : TargetScript
{
    public AudioClip ding;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {

            Destroy(this.gameObject);

        }
    }
}
