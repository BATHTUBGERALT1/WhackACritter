﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    //display visual timer 
    public TextMesh displayText;

    // starting time for the timer 
    public float timerDuration; 

    // seconds remaining on the timer
    private float timeRemaining = 0; 


	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsTimerRunning())
        {
            // timer is running so process

            // UPDATED THE TIME REMAINING THIS FRAME
            timeRemaining = timeRemaining - Time.deltaTime;

            // check if we have now run out of time 
            if (timeRemaining <= 0)
            {

                StopTimer();
            }
            // update the visual display
            displayText.text = Mathf.CeilToInt(timeRemaining).ToString();
        }
	}

    //starts the timer counting 
    public void StartTimer()
    {
        timeRemaining = timerDuration;
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();  

    }

    //stop the timer counting 
    public void StopTimer()
    {

        timeRemaining = 0;
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();
    }

    // is the timer still running 
    public bool IsTimerRunning()
    {
        if (timeRemaining != 0)
        {
            return true;

        }
        else
        {
            return false;

        }
    }
}
