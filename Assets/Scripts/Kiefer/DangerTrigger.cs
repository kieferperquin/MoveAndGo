using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTrigger : MonoBehaviour
{
    [SerializeField] private bool startLava, stopLava, startFH, stopFH;
    [SerializeField] private DangerManager dm;

    private void Awake()
    {
        TriggerEnterer.TriggerEntered += Entered;
    }
    private void Entered()
    {
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
