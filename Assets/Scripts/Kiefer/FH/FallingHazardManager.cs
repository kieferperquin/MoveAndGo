using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingHazardManager : MonoBehaviour
{
    [SerializeField] private GameObject[] FH;
    [SerializeField] private GameObject[] lanes;
    
    [SerializeField] private int maxTime;
    [SerializeField] private int minTime;

    private float spawnInterval;
    private float timer;
    
    private bool spawn;
    private bool started;

    private void Start()
    {
        spawnInterval = Random.Range(minTime, maxTime);
    }

    private void Update()
    {
        if (started)
        {
            timer += Time.deltaTime;

            if (timer >= spawnInterval)
            {
                spawn = true;
                spawnInterval = Random.Range(minTime, maxTime);
                timer = 0f;
            }
        }

        if (spawn)
        {
            SpawnFH();
            spawn = false;
        }
    }

    void SpawnFH()
    {
        Instantiate(FH[Random.Range(0, FH.Length)], CalRowToSpawn(Random.Range(0, lanes.Length)), Quaternion.identity);
    }

    Vector3 CalRowToSpawn(int random)
    {
        return lanes[random].transform.position;
    }

    public void StartFH()
    {
        started = true;
    }

    public void StopFH()
    {
        started = false;
    }
}
