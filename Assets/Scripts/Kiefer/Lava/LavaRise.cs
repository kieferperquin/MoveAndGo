using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    [SerializeField] private GameObject MaxHeight;

    private int maxTime;

    private float heightDifPerSecond;

    private Vector3 currHeight;
    private Vector3 heightDiff;

    private bool started = false;

    void Start()
    {
        heightDifPerSecond = (MaxHeight.transform.position.y - gameObject.transform.position.y) / maxTime;
        gameObject.transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (started && gameObject.transform.position.y < MaxHeight.transform.position.y)
        {
            LavaRising();
        }
    }

    void LavaRising()
    {
        currHeight = gameObject.transform.position;

        heightDiff = currHeight;
        heightDiff.y = currHeight.y + heightDifPerSecond;

        currHeight = heightDiff;
        gameObject.transform.position = currHeight * Time.deltaTime;
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