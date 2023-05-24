using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaManager : MonoBehaviour
{
    [SerializeField] GameObject lava;

    public void StartLava()
    {
        lava.GetComponent<LavaRise>().startRising();
    }
    public void Reset()
    {
        lava.GetComponent<LavaRise>().Reset();
    }
}
