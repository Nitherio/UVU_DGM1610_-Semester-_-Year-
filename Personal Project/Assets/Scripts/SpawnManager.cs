using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] wispPrefabs;

    private float SpawnRangeX = 11;

    private float SpawnPosZ = 11;

    private float startDelay = 2;

    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomWisps", startDelay, spawnInterval);
    }

    void SpawnRandomWisps()
    {
        //Randomly generate wisp spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        int wispIndex = Random.Range(0, wispPrefabs.Length);
        Instantiate(wispPrefabs[wispIndex], spawnPos, wispPrefabs[wispIndex].transform.rotation);
    }
}