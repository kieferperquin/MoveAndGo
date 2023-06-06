using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaManager : MonoBehaviour
{
    [SerializeField] private GameObject lava;

    public int maxTime;

    public void StartLava()
    {
        lava.GetComponent<LavaRise>().SetMaxTime(maxTime);
        lava.GetComponent<LavaRise>().startRising();
    }

    public void ResetLava()
    {
        lava.GetComponent<LavaRise>().Reset();
    }
}