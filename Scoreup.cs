using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.Kinect.VisualGestureBuilder;

public class Scoreup : MonoBehaviour {

    public static float score;        // The player's score.
    Text text;                      // Reference to the Text component.
    //public GestureSourceManager getCombo;

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }

    void Update()
    {
            text.text = " " + score;
    }

}
