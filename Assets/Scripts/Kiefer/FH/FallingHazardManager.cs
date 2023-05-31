using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingHazardManager : MonoBehaviour
{
    [SerializeField] GameObject[] FH;
    [SerializeField] GameObject[] lanes;
    [SerializeField] bool spawn;

    private void Update()
    {
        if (spawn)
        {
            SpawnFH();
            spawn = false;
        }
    }

    void SpawnFH()
    {
        System.Random rnd = new System.Random();

        Instantiate(FH[rnd.Next(FH.Length)], CalRowToSpawn(), Quaternion.identity);
    }

    Vector3 CalRowToSpawn()
    {






        Vector3 place1;
        place1.x = 1;
        place1.y = 1;
        place1.z = 1;
        return place1;
    }
}
