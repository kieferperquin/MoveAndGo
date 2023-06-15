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
        dm = GameObject.Find("Danger").GetComponent<DangerManager>();
    }
    private void OnDestroy()
    {
        TriggerEnterer.TriggerEntered -= Entered;
    }
    private void Entered(string name)
    {
        if (name == gameObject.name)
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
}
