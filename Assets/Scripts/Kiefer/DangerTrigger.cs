using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTrigger : MonoBehaviour
{
    [SerializeField] bool startLava, stopLava, startFH, stopFH;
    private void OnTriggerEnter(Collider other)
    {
        if (startLava)
        {
            DangerManager.instance.LavaStart();
        }
        else if (stopLava)
        {
            DangerManager.instance.LavaReset();
        }
        else if (startFH)
        {
            DangerManager.instance.FHStart();
        }
        else if (stopFH)
        {
            DangerManager.instance.FHStop();
        }
    }
}
