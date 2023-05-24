using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    [SerializeField] GameObject MaxHight;

    int maxTime;

    int currTime;
    int timeWaited;
    int loopTimer;

    Vector3 CurrentPos;
    Vector3 GoingPos;

    float hightDifPerSecond;

    bool started = false;
    bool once = false;

    void Start()
    {
        float hightDif = MathF.Abs(this.gameObject.transform.position.y - MaxHight.transform.position.y);
        hightDifPerSecond = hightDif / maxTime;
        currTime = 1;
    }

    void Update()
    {
        if (started)
        {
            if (!once)
            {
                once = true;

                timeWaited += (int)Time.time;
            }

            loopTimer = (int)Time.time - timeWaited;

            if (loopTimer >= currTime && currTime < maxTime)
            {
                currTime++;
                LavaIncrease();
            }
        }
    }

    void LavaIncrease()
    {
        CurrentPos = gameObject.transform.position;

        GoingPos = CurrentPos;
        GoingPos.y = CurrentPos.y + hightDifPerSecond;

        gameObject.transform.position = GoingPos;
    }

    public void startRising()
    {
        started = true;
    }

    public void Reset()
    {
        Start();   
    }

    public void SetMaxTime(int time)
    {
        maxTime = time;
    }
}