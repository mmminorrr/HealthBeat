using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Microsoft.Kinect.VisualGestureBuilder;

public class TimeSetManager : MonoBehaviour {

    AudioSource audioSource;

    public float timer;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        
    }
    void Update()
    {
            Debug.Log(audioSource.time);
            timer = audioSource.time;

            /*if(timer == 5)
            {
                Debug.Log("********** 5 Seconds **********");
                loadScene = true;
            }*/
     
    }
}
