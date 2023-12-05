using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TrackTime : MonoBehaviour
{
    
    public Text timeString;

    void Update()
        {
            // Update the timer if it is running
            if (TimerManager.Instance != null)
            {
                TimerManager.Instance.UpdateTimer();
                timeString.text = TimerManager.Instance.Timer.ToString("0.00");
            }
        }



}
