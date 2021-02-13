using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -24;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;


    bool isSpawning = false;
    public float minTime = 3.0f;
    public float maxTime = 5.0f;


    IEnumerator SpawnObject(int index, float seconds)
    {
        Debug.Log("Waiting for " + seconds + " seconds");
        int randomBall = Random.Range(0, ballPrefabs.Length);
        yield return new WaitForSeconds(seconds);
        Instantiate(ballPrefabs[randomBall], transform.position, transform.rotation);

        //We've spawned, so now we could start another spawn     
        isSpawning = false;
    }

    void Update()
    {
        //We only want to spawn one at a time, so make sure we're not already making that call
        if (!isSpawning)
        {
            isSpawning = true; //Yep, we're going to spawn
            int enemyIndex = Random.Range(0, ballPrefabs.Length);
            StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomBall = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
    }

}
