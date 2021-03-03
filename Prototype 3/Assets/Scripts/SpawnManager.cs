using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public float startDelay = 2.0f;

    public float repeatRate = 2f;

    private Vector3 spawnPos = new Vector3(25,0,0);

    private PlayerMovement playerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
        playerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void SpawnObstacle()
    {
        if (playerMovementScript.isGameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
