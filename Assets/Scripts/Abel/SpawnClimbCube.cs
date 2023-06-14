using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClimbCube : MonoBehaviour
{
    [SerializeField] private GameObject ClimbCube;
    private void Start()
    {
        foreach (Transform child in transform)
        {
            Instantiate(ClimbCube, child);
        }
    }
}
