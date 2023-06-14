using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRise : MonoBehaviour
{
    #region Variables
    [SerializeField] private GameObject HeightLimit;

    [SerializeField] private int maxTime;

    private float currTime;

    private Vector3 MaxHeight;
    private Vector3 StartingPos;

    private bool started = false;
    #endregion
    #region Code
    void Start()
    {
        currTime = 0;
        MaxHeight = HeightLimit.transform.position;
        started = false;
        gameObject.transform.position = new Vector3(0, 0, 0);
        StartingPos = gameObject.transform.position;
    }

    void Update()
    {
        if (started && currTime < maxTime)
        {
            LavaRising();
        }
    }

    void LavaRising()
    {
        currTime += Time.deltaTime;

        if (gameObject.transform.position.y < MaxHeight.y)
        {
            gameObject.transform.position = Vector3.Lerp(StartingPos, MaxHeight, currTime / maxTime);
        }
    }
    #endregion
    #region PublicVoids
    public void StartLava()
    {
        started = true;
    }
    public void ResetLava()
    {
        MaxHeight = HeightLimit.transform.position;
        started = false;
        gameObject.transform.position = new Vector3(0, 0, 0);
        StartingPos = gameObject.transform.position;
    }
    #endregion
}