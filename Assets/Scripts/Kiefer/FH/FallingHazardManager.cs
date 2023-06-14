using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Xml.Linq;

public class FallingHazardManager : MonoBehaviour
{
    #region variables
    [SerializeField] private GameObject[] FH;
    [SerializeField] private GameObject[] lanes;

    [SerializeField] private Color[] colorCodes;

    [SerializeField] private TMP_Text warningText;

    [SerializeField] private int minTime;
    [SerializeField] private int maxTime;

    [SerializeField] private float warningTime;

    private int spawnLocation;

    private float spawnInt;
    private float timer;
    
    private bool spawn;
    private bool started;
    #endregion
    #region code
    private void Start()
    {
        if (lanes.Length != colorCodes.Length)
        {
            Debug.LogError("colors != lanes");
        }
        CalSpawnInt();
        SetSpawnLoc();
    }

    private void Update()
    {
        if (!started)// false
            return;

        timer += Time.deltaTime;

        if (timer >= spawnInt)
        {
            spawn = true;
            CalSpawnInt();
            timer = 0f;
        }
        if (timer >= spawnInt - warningTime)
        {
            warningText.color = colorCodes[spawnLocation];
        }
        if (spawn)// true
        {
            warningText.color = Color.clear;
            int whatFH = Random.Range(0, FH.Length);
            Instantiate(FH[whatFH], lanes[spawnLocation].transform.position, FH[whatFH].transform.rotation);

            SetSpawnLoc();
            spawn = false;
        }
    }

    void SetSpawnLoc()
    {
        spawnLocation = Random.Range(0, lanes.Length);
        Debug.Log(spawnLocation);
    }

    void CalSpawnInt()
    {
        spawnInt = Random.Range(minTime, maxTime);
    }
    #endregion
    #region public voids
    public void StartFH()
    {
        started = true;
    }
    public void StopFH()
    {
        started = false;
        CalSpawnInt();
        SetSpawnLoc();
    }
    #endregion
}