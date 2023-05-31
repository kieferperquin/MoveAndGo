using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaManager : MonoBehaviour
{
    [SerializeField] private GameObject lava;
    public int maxTime;
    [SerializeField] private bool startTest;

    private void Update()
    {
        if (startTest)
        {
            StartLava();
            startTest = false;
        }
    }
    public void StartLava()
    {
        lava.GetComponent<LavaRise>().SetMaxTime(maxTime);
        lava.GetComponent<LavaRise>().startRising();
    }

    public void Reset()
    {
        lava.GetComponent<LavaRise>().Reset();
    }
}