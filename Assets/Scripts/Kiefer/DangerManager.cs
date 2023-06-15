using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DangerManager : MonoBehaviour
{
    public static DangerManager instance;

    [SerializeField] private GameObject FHManager;
    private FallingHazardManager fallingHazardManager;
    [SerializeField] private GameObject Lava;
    private LavaRise lavaRise;

    [SerializeField] private bool Lava_Start;
    [SerializeField] private bool Lava_Reset;
    [SerializeField] private bool FH_Start;
    [SerializeField] private bool FH_Stop;

    private void Awake()
    {
        lavaRise = Lava.GetComponent<LavaRise>();
        fallingHazardManager = FHManager.GetComponent<FallingHazardManager>();
    }
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
        // Lava = GameObject.Find("Lava");
    }
    public void LavaStart()
    {
        lavaRise.StartLava();
    }
    public void LavaReset()
    {
        lavaRise.ResetLava();
    }
    public void FHStart()
    {
        fallingHazardManager.StartFH();
    }
    public void FHStop()
    {
        fallingHazardManager.StopFH();
    }
}
