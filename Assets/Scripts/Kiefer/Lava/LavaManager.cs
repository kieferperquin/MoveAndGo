using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaManager : MonoBehaviour
{
    [SerializeField] GameObject lava;
    public int maxTime;

    private void Start()
    {
        lava.GetComponent<LavaRise>().SetMaxTime(maxTime);
    }

    public void StartLava()
    {
        lava.GetComponent<LavaRise>().startRising();
    }
    public void Reset()
    {
        lava.GetComponent<LavaRise>().Reset();
    }
}
