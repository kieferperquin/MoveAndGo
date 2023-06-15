using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class TriggerEnterer : MonoBehaviour
{
    public static event Action<string> TriggerEntered;
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
            TriggerEntered?.Invoke(trigger.name);
            txt.color = Color.clear;
            txt.text = "!! WARNING !!";
            if (trigger.name == "EndTrigger")
            {
                txt.color = Color.yellow;
                txt.text = "!! You did it !! \n You should touch the GLOWING YELLOW SPHERE.";
            }
        }
        if (trigger.gameObject.layer == LayerMask.NameToLayer("Hazard"))
        {
            ReloadScene();
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
