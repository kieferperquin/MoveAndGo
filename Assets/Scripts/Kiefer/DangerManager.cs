using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerManager : MonoBehaviour
{
    [SerializeField] GameObject FHManager;
    [SerializeField] GameObject Lava;

    [SerializeField] private bool Lava_Start;
    [SerializeField] private bool Lava_Reset;
    [SerializeField] private bool FH_Start;
    [SerializeField] private bool FH_Stop;
    private void Update()
    {
        if (Lava_Start)
        {
            LavaStart();
        }
        if (Lava_Reset)
        {
            LavaReset();
        }
        if (FH_Start)
        {
            FHStart();
        }
        if (FH_Stop)
        {
            FHStop();
        }
    }
    public void LavaStart()
    {
        Lava.GetComponent<LavaManager>().StartLava();
    }
    public void LavaReset()
    {
        Lava.GetComponent<LavaManager>().ResetLava();
    }
    public void FHStart()
    {
        FHManager.GetComponent<FallingHazardManager>().StartFH();
    }
    public void FHStop()
    {
        FHManager.GetComponent<FallingHazardManager>().StopFH();
    }
}
