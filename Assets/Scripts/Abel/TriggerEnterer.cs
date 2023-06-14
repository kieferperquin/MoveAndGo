using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class TriggerEnterer : MonoBehaviour
{
    public static event Action TriggerEntered;
    [SerializeField] private TMP_Text txt;

    private void Start()
    {
        txt.color = Color.red;
        txt.text = "!! GET TO THE TOP !! \n WATCH OUT FOR RISING LAVA \n AND FALLING HAZARDS";
    }

    private void OnTriggerEnter(Collider trigger)
    {
        if (trigger.gameObject.layer == LayerMask.NameToLayer("Trigger"))
        {
            TriggerEntered?.Invoke();
            txt.color = Color.clear;
            txt.text = "!! WARNING !!";
        }
        if (trigger.gameObject.layer == LayerMask.NameToLayer("Hazard"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
