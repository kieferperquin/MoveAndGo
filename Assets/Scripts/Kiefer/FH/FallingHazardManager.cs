using UnityEngine;
using UnityEngine.UI;

public class FallingHazardManager : MonoBehaviour
{
    [SerializeField] private GameObject[] FH;
    [SerializeField] private GameObject[] lanes;

    [SerializeField] private Color[] colorCodes;

    [SerializeField] private GameObject warningText;

    [SerializeField] private int minTime;
    [SerializeField] private int maxTime;

    [SerializeField] private float warningTime;

    private int spawnLocation;

    private float spawnInt;
    private float timer;
    
    private bool spawn;
    private bool started;

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
        if (!started)
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
            SpawnWarningIndicator();
        }
        if (spawn)
        {
            SpawnFH();
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
    void SpawnFH()
    {
        warningText.SetActive(false);
        int whatFH = Random.Range(0, FH.Length);

        Instantiate(FH[whatFH], CalRowToSpawn(), FH[whatFH].transform.rotation);
    }
    void SpawnWarningIndicator()
    {
        warningText.SetActive(true);
        SetTextColor(warningText);
    }
    void SetTextColor(GameObject txtObject)
    {
        txtObject.GetComponent<Text>().color = colorCodes[spawnLocation];
    }
    Vector3 CalRowToSpawn()
    {
        return lanes[spawnLocation].transform.position;
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