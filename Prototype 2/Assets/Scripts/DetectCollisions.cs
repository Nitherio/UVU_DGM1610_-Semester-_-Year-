using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // Destory this object that a script is attached to
        Destroy(gameObject);
        // Destory other object hits a trigger
        Destroy(other.gameObject);
    }


}
