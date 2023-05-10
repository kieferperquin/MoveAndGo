using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    bool started = true;

    [SerializeField] GameObject MaxHight;

    public int MaxTime;
    int currTime = 1;

    Vector3 CurrentPos;

    float hightDifPerSecond;

    private void Start()
    {
        float hightDif = MathF.Abs(this.gameObject.transform.position.y - MaxHight.transform.position.y);
        hightDifPerSecond = hightDif / MaxTime;
    }

    void Update()
    {
        if (started)
        {
            while (MaxTime >= currTime)
            {
                InvokeRepeating("LavaIncreases", 1f, 1f);
            }
            if (MaxTime < currTime)
            {
                CancelInvoke();
            }
        }
    }

    void LavaIncrease()
    {
        currTime++;
        Debug.Log(Time.time);
        //CurrentPos = this.gameObject.transform.position;
    }

    public void StartRizing()
    {
        started = true;
    }
}