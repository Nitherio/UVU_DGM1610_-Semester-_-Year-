using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public GameObject propeller;

    private float rotationSpeed = 150.0f;


    // Update is called once per frame
    void Update()
    {
        // roatation of propeller
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
    }
}
