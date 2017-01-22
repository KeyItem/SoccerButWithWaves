﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float initialTime;

    private float delayTime;

    public Timer(float p_delayTime = 0)
    {
        ResetTimer(p_delayTime);
    }

    public float GetRatio()
    {
        float actualTime = Time.time;

        if (actualTime == initialTime)
        {
            return 0;
        }

        float ratio = Mathf.Clamp((actualTime - initialTime) / delayTime, 0f, 1f);
        return ratio;
    }

    public bool TimerIsDone()
    {
        return (GetRatio() == 1);
    }

    public void ResetTimer(float p_delayTime)
    {
        delayTime = p_delayTime;
        initialTime = Time.time;
    }

}