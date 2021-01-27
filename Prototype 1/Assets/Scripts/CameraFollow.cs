using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -11);


    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
