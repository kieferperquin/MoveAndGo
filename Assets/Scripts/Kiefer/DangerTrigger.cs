using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTrigger : MonoBehaviour
{
    [SerializeField] private bool startLava, stopLava, startFH, stopFH;
    private DangerManager dm;

    private void Start()
    {
        TriggerEnterer.TriggerEntered += Entered;
        Debug.Log("START CALLED");
        dm = GameObject.Find("Danger").GetComponent<DangerManager>();
    }
    private void OnDestroy()
    {
        TriggerEnterer.TriggerEntered -= Entered;
        Debug.Log("DESTROY CALLED");
    }
    private void Entered()
    {
        Debug.Log("ENTERED CALLED");
        if (startLava)
        {
            dm.LavaStart();
        }
        else if (stopLava)
        {
            dm.LavaReset();
        }
        if (startFH)
        {
            dm.FHStart();
        }
        else if (stopFH)
        {
            dm.FHStop();
        }
    }
}
